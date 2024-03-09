using LinhChiDoiSOS.Application.Models;
using LinhChiDoiSOS.Application.Models.Identity;

namespace LinhChiDoiSOS.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
        /// <summary>
        /// Dùng để generate JWT
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<string> AuthenticateAsync(string Email, string password);
        Task<TokenModel> AuthenticateWithRTAsync(string Email, string password);
        Task<TokenModel> RenewToken(TokenModel model);
    }
}
