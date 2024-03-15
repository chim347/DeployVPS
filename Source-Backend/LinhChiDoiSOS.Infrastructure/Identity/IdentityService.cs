using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Models;
using LinhChiDoiSOS.Application.Models.Identity;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace LinhChiDoiSOS.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        #region Private fields
        private ILinhChiDoiSOSDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
        private readonly IAuthorizationService _authorizationService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly JwtSettings _jwtSettings;
        #endregion

        #region Constructors
        public IdentityService(
        ILinhChiDoiSOSDbContext dbContext,
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
        IOptions<JwtSettings> jwtSettings,
        IAuthorizationService authorizationService,
        IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
            _authorizationService = authorizationService;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _jwtSettings = jwtSettings.Value;
        }
        #endregion

        #region RenewToken
        public async Task<TokenModel> RenewToken(TokenModel model)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtSettings.Key);
            var tokenValidateParam = new TokenValidationParameters
            {
                //Tự cấp Token
                ValidateIssuer = false,
                ValidateAudience = false,

                //Ký vào token
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                ValidateLifetime = false,//Kh kiểm tra token hết hạn
            };
            try
            {
                //Check 1: AccessToken Valid Format
                var tokenInverification = jwtTokenHandler.ValidateToken(model.AccessToken, tokenValidateParam, out var validateToken);

                //Check 2: Check Alg
                if (validateToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512Signature, StringComparison.InvariantCultureIgnoreCase);
                    if (!result)
                    {
                        throw new InvalidOperationException("Có lỗi xãy ra trong quá trình refresh token!!!!");
                    }
                }
                //Check 3: Check accessToken expire?
                var utcExpireDate = long.Parse(tokenInverification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

                var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
                if (expireDate > DateTime.UtcNow)
                {
                    throw new InvalidOperationException("Token chưa hết hạn!!!!");
                }
                //Check 4: Check refreshtoken exist in DB
                var storedToken = _dbContext.RefreshToken.FirstOrDefault(x => x.RefreshTOken == model.RefreshToken);
                if (storedToken == null)
                {
                    throw new InvalidOperationException("Token chưa từng tồn tại!!!");
                }
                if (storedToken.IsRevoked)
                {
                    throw new InvalidOperationException("Token đã được sử dụng!!!");
                }
                //Check 6: Accesstoken id 
                var jti = tokenInverification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti)!.Value;
                if (storedToken.JwtId != jti)
                {
                    throw new InvalidOperationException("Token có vấn đề!!!!");
                }
                //Update token is used
                storedToken.IsRevoked = true;
                storedToken.IsUsed = true;
                _dbContext.RefreshToken.Update(storedToken);
                await _dbContext.SaveChangesAsync();

                //Create new token
                var user = await _dbContext.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == storedToken.ApplicationUserId);
                var token = await GenerateToken(user!);
                return token;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Đăng nhập thất bại!!!");
            }
        }
        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var result = dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();
            return result;
        }
        #endregion



        private string GenerateRefreshToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
                return Convert.ToBase64String(random);
            }
        }
        public async Task<TokenModel> AuthenticateWithRTAsync(string username, string password)
        {
            var user = await _userManager.FindByEmailAsync(username);

            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(username);
                if (user == null)
                {
                    throw new KeyNotFoundException($"Không tìm thấy tên đăng nhập hoặc địa chỉ email '{username}'");
                }
            }
            if (user.LockoutEnd != null && user.LockoutEnd.Value > DateTime.Now)
            {
                throw new KeyNotFoundException($"Tài khoản này hiện tại đang bị khóa. Vui lòng liên hệ quản trị viên để được hỗ trợ");
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
            var result = await GenerateToken(user);
           // var test = RenewToken(result);
            return result;

            throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
        }
        private async Task<TokenModel> GenerateToken(ApplicationUser user)
        {
            try
            {
                var userClaims = await _userManager.GetClaimsAsync(user);
                var roles = await _userManager.GetRolesAsync(user);
                var roleClaims = roles.Select(q => new Claim("role", q)).ToList();
                var customer = await _dbContext.Customer.Where(c => c.ApplicationUserId == user.Id).SingleOrDefaultAsync();


                List<Claim> authClaims = new List<Claim>();

                if (customer != null)
                {
                    var userHaveBooking = await _dbContext.Booking.Where(u => u.CustomerId == customer.Id).SingleOrDefaultAsync();
                    if (userHaveBooking == null)
                    {
                        authClaims.Add(new Claim("isPaid", "false"));
                    }
                    else
                    {
                        authClaims.Add(new Claim("isPaid", "true"));
                    }
                }

                authClaims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.UserName));
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                authClaims.Add(new Claim("Id", user.Id));
                foreach (var item in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, item));
                }

                var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
                var token = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    claims: authClaims.Union(userClaims).Union(roleClaims),
                    expires: DateTime.UtcNow.AddHours(7).AddMinutes(_jwtSettings.DurationInMinutes),
                    signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
                    );

                var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
                var refreshToken = GenerateRefreshToken();

                //Lưu RefreshToken vào Database
                var refreshTokenEntity = new RefreshToken
                {
                    ApplicationUserId = user.Id,
                    Id = Guid.NewGuid(),
                    JwtId = token.Id,
                    RefreshTOken = refreshToken,
                    IsUsed = false,
                    IsRevoked = false,
                    IssuedAt = DateTime.Now,
                    ExpiredAt = DateTime.Now.AddDays(30),
                };

                _dbContext.RefreshToken.Add(refreshTokenEntity);
                await _dbContext.SaveChangesAsync();

                return new TokenModel()
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                    Expires = DateTime.UtcNow.AddHours(7).AddMinutes(_jwtSettings.DurationInMinutes),
            };
            }
            catch
            {
                throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
            }
        }
        /// <summary>
        /// Dùng để generate JWT
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<string> AuthenticateAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(username);
                if (user == null)
                {
                    throw new KeyNotFoundException($"Không tìm thấy tên đăng nhập hoặc địa chỉ email '{username}'");
                }
            }
            if (user.LockoutEnd != null && user.LockoutEnd.Value > DateTime.Now)
            {
                throw new KeyNotFoundException($"Tài khoản này hiện tại đang bị khóa. Vui lòng liên hệ quản trị viên để được hỗ trợ");
            }
            /*if (user.EmailConfirmed == false)
            {
                throw new KeyNotFoundException($"Email của tài khoản này chưa được xác nhận. Vui lòng nhấn quên mật khẩu!");

            }*/

            //sign in  
            var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
            if (signInResult.Succeeded)
            {
                var roles = await _userManager.GetRolesAsync(user);
                List<Claim> authClaims = new List<Claim>();
                authClaims.Add(new Claim(ClaimTypes.Email, user.Email));
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                foreach (var item in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, item));
                }

                var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

                var token = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    expires: DateTime.Now.AddHours(7).AddMinutes(_jwtSettings.DurationInMinutes),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
                    );
                return new JwtSecurityTokenHandler().WriteToken(token);

                //return await _userClaimsPrincipalFactory.CreateAsync(user) ?? throw new InvalidOperationException("Authenticated failed, please contact administrator!");
            }

            throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
        }

        public async Task<bool> AuthorizeAsync(string userId, string policyName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return false;
            }

            var userPrincipal = await _userClaimsPrincipalFactory.CreateAsync(user);

            var result = await _authorizationService.AuthorizeAsync(userPrincipal, policyName);

            return result.Succeeded;
        }

        public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new ApplicationUser { UserName = userName, Email = userName };
            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<Result> DeleteUserAsync(string userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            return user != null ? await DeleteUserAsync(user) : Result.Success();
        }

        public async Task<Result> DeleteUserAsync(ApplicationUser user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }

        public async Task<string?> GetUserNameAsync(string userId)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }

        public async Task<bool> IsInRoleAsync(string userId, string role)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            return user != null && await _userManager.IsInRoleAsync(user, role);
        }
    }
}
