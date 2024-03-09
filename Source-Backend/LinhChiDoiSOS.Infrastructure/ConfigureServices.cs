using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Models.Identity;
using LinhChiDoiSOS.Domain.IdentityModels;
using LinhChiDoiSOS.Infrastructure.Files;
using LinhChiDoiSOS.Infrastructure.Identity;
using LinhChiDoiSOS.Infrastructure.Persistence;
using LinhChiDoiSOS.Infrastructure.Persistence.Interceptors;
using LinhChiDoiSOS.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace LinhChiDoiSOS.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            if (configuration.GetValue<bool>("UseInMemoryDatabase")) {
                services.AddDbContext<LinhChiDoiSOSDbContext>(options =>
                                   options.UseInMemoryDatabase("LinhChiDoiSOSDb123"));
            }
            else {
                services.AddDbContext<LinhChiDoiSOSDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                        builder => builder.MigrationsAssembly(typeof(LinhChiDoiSOSDbContext).Assembly.FullName)));
            }

            services.AddScoped<ILinhChiDoiSOSDbContext>(provider => provider.GetRequiredService<LinhChiDoiSOSDbContext>());
            services.AddScoped<LinhChiDoiSOSDbContextInitialiser>();

            services
            .AddDefaultIdentity<ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<LinhChiDoiSOSDbContext>();

            services.AddIdentityServer()
            .AddApiAuthorization<ApplicationUser, LinhChiDoiSOSDbContext>();

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

            var secretKey = configuration["JwtSettings:Key"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

            services.AddAuthentication(o =>
            {
                o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
               {
                   options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                   options.SlidingExpiration = true;
                   options.AccessDeniedPath = "/Forbidden/";
                   options.LoginPath = "/Login";
                   options.LogoutPath = "/Logout";
                   options.ReturnUrlParameter = "redirectUrl";
                   options.Cookie.IsEssential = true;
                   options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                   options.Cookie.SameSite = SameSiteMode.Lax;
               }).AddJwtBearer(opt =>
               {
                   /*opt.TokenValidationParameters = new TokenValidationParameters
                   {
                       //tự cấp token
                       ValidateIssuer = false,
                       ValidateAudience = false,

                       //ký vào token
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                       ClockSkew = TimeSpan.Zero
                   };*/
                   opt.SaveToken = true;
                   opt.RequireHttpsMetadata = false;
                   opt.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ClockSkew = TimeSpan.Zero,
                       ValidIssuer = configuration["JwtSettings:Issuer"],
                       ValidAudience = configuration["JwtSettings:Audience"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                   };
               });

            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
                {
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    BearerFormat = "JwtSettings",
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Name = "Authorization",
                    Description = "Insert JWT Token"
                });
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    //.AddAuthenticationSchemes(
                    //    CookieAuthenticationDefaults.AuthenticationScheme‌​,
                    //    GoogleDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();

                options.AddPolicy("Manager", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Manager")
                    .Build());
                options.AddPolicy("Admin", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Admin")
                    .Build());
                options.AddPolicy("Customer", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("Customer")
                   .Build());
                options.AddPolicy("AdminOrManager", policy => policy
            .Combine(options.DefaultPolicy)
            .RequireRole("Manager", "Admin")
            .Build());
            });

            /*services.AddSwaggerGen(options =>
            {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JwtSettings",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Type = SecuritySchemeType.ApiKey,
                    Description = "Put \"Bearer {token}\" your JWT Bearer token on textbox below!",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = JwtBearerDefaults.AuthenticationScheme
                    },
                };
                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, jwtSecurityScheme);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        jwtSecurityScheme,
                        new List<string>()
                    }
                });
            });*/

            services.AddSession();

            return services;
        }
    }
}
