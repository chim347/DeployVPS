using Duende.IdentityServer.EntityFramework.Options;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.Entities.Payments;
using LinhChiDoiSOS.Domain.IdentityModels;
using LinhChiDoiSOS.Infrastructure.Persistence.Interceptors;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace LinhChiDoiSOS.Infrastructure.Persistence
{
    public class LinhChiDoiSOSDbContext : ApiAuthorizationDbContext<ApplicationUser>, ILinhChiDoiSOSDbContext
    {
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

        public LinhChiDoiSOSDbContext(
            DbContextOptions<LinhChiDoiSOSDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options, operationalStoreOptions)
        {
            _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetail> BookingDetail { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ComboCourse> ComboCourse { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDetail> CourseDetail { get; set; }
        public DbSet<Emergency> Emergency { get; set; }
        public DbSet<EmergencyCategory> EmergencyCategory { get; set; }
        public DbSet<EmergencyDetail> EmergencyDetail { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<MiniContent> MiniContent { get; set; }
        public DbSet<AnswerContent> AnswerContents { get; set; }
        public DbSet<ChuanDoan> ChuanDoan { get; set; }
        public DbSet<Keyword> Keyword { get; set; }
        public DbSet<CategoryKeyword> CategoryKeyword { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<PaymentDestination> PaymentDestination { get; set; }
        public DbSet<PaymentNotification> PaymentNotification { get; set; }
        public DbSet<PaymentSignature> PaymentSignature { get; set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<StepOfCourseDetail> StepOfCourseDetail { get; set; }
        public DbSet<ChuanDoan_Keyword> ChuanDoan_Keyword { get; set; }

        private Guid GuidParse(string guid)
        {
            guid = guid.Replace("{", "").Replace("}", "");

            if (Guid.TryParse(guid, out Guid result))
            {
                return result;
            }
            else
            {
                return Guid.Empty;
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region Accounts
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<AppIdentityRole>()
                .HasData(
                    new AppIdentityRole
                    {
                        Id = "37dde3f4-d0c9-4477-97d6-ff29f677dccc",
                        Name = "Manager",
                        NormalizedName = "MANAGER",
                        ConcurrencyStamp = null,
                        Description = "Quản lí hệ thống"
                    },
                    new AppIdentityRole
                    {
                        Id = "b9cf3487-3d04-4cbf-85b7-e33360566485",
                        Name = "Customer",
                        NormalizedName = "CUSTOMER",
                        ConcurrencyStamp = null,
                        Description = "Khách hàng"
                    }
                );
            builder.Entity<ApplicationUser>()
                .HasData(
                    new ApplicationUser
                    {
                        Id = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                        Fullname = "Nguyễn Thành Nhân",
                        BirthDay = DateTime.Parse("2002-06-20 08:30:56"),
                        Image = null,
                        UserName = "NhanNguyen",
                        NormalizedUserName = "NHANNGUYEN",
                        Email = "nhan@gmail.com",
                        NormalizedEmail = "NHAN@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Passw0rd1"),
                        SecurityStamp = "FHSBRSP7Q6SW6JWBVKCFBC6LKFR4MAR7",
                        ConcurrencyStamp = "445607b7-57f3-4092-9129-c8becc104929",
                        PhoneNumber = "0961868641",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    }
                );
            builder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                        RoleId = "37dde3f4-d0c9-4477-97d6-ff29f677dccc"
                    }
                );
            #endregion
            #region Emergency Categories
            builder.Entity<EmergencyCategory>()
                .HasData(
        new EmergencyCategory
        {
            Id = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
            Name = "Khẩn cấp",
            PriorityLevel = 1,
        },
        new EmergencyCategory
        {
            Id = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
            Name = "Ưu tiên",
            PriorityLevel = 2,
        },
        new EmergencyCategory
        {
            Id = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
            Name = "Thương tích",
            PriorityLevel = 3,
        },
        new EmergencyCategory
        {
            Id = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
            Name = "Bệnh lý",
            PriorityLevel = 4,
        },
        new EmergencyCategory
        {
            Id = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
            Name = "Kỹ năng",
            PriorityLevel = 5,
        }
    );
            #endregion
            #region Emergencies
            builder.Entity<Emergency>()
                .HasData(
                    //Khẩn cấp 5DCA6C16-F112-4517-8655-3B03CFB7A716
            #region Khẩn cấp
                    new Emergency
                    {
                        EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                        Id = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                        Title = "Hỏa hoạn",
                        Image = @"<svg width=""73"" height=""87"" viewBox=""0 0 73 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.185181"" y=""0.759262"" width=""72.514"" height=""85.463"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_680"" transform=""matrix(0.00290289 0 0 0.00246305 -0.00655345 0)""/>
</pattern>
<image id=""image0_269_680"" width=""349"" height=""406"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"
                    },
                    new Emergency
                    {
                        EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                        Id = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                        Title = "Đột quỵ",
                        Image = @"<svg width=""103"" height=""87"" viewBox=""0 0 103 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.722229"" y=""0.759262"" width=""101.956"" height=""85.463"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_686"" transform=""matrix(0.00238135 0 0 0.00284091 -0.00246487 0)""/>
</pattern>
<image id=""image0_269_686"" width=""422"" height=""352"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"
                    },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                         Id = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                         Title = "Đuối nước",
                         Image = @"<svg width=""115"" height=""87"" viewBox=""0 0 115 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.462967"" y=""0.759262"" width=""113.951"" height=""85.463"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_690"" transform=""matrix(0.00165289 0 0 0.00220386 0 -0.00909092)""/>
</pattern>
<image id=""image0_269_690"" width=""605"" height=""462"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"

                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                         Id = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                         Title = "Điện giật",
                         Image = @"<svg width=""56"" height=""80"" viewBox=""0 0 56 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M6.13976 44.5702C8.06477 46.9222 12.9606 55.6352 14 60H42C43.0396 55.6386 47.9296 46.9256 49.8546 44.577C53.1524 40.5434 55.2198 35.6792 55.8188 30.545C56.418 25.4106 55.5242 20.2148 53.2408 15.5564C50.9574 10.8978 47.377 6.96598 42.9122 4.21374C38.4474 1.4615 33.2796 0.000820346 28.0044 3.45448e-07C22.7292 -0.000819655 17.5612 1.45822 13.0954 4.20906C8.62977 6.9599 5.04797 10.8906 2.76316 15.5484C0.478163 20.2062 -0.417298 25.4016 0.180163 30.5362C0.777563 35.6708 2.84336 40.5356 6.13976 44.5702ZM30 16L18 34H26V46L38 28H30V16Z"" fill=""#F23929""/>
<path d=""M42 72H14V76C14 78.2092 15.7908 80 18 80H38C40.2092 80 42 78.2092 42 76V72Z"" fill=""#F23929""/>
<path d=""M14 66C14 64.8954 14.8954 64 16 64H40C41.1046 64 42 64.8954 42 66C42 67.1046 41.1046 68 40 68H16C14.8954 68 14 67.1046 14 66Z"" fill=""#F23929""/>
</svg>

"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                         Id = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                         Title = "Hóc dị vật",
                         Image = @"<svg width=""39"" height=""87"" viewBox=""0 0 39 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.277771"" y=""0.759262"" width=""38.207"" height=""85.463"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_694"" transform=""matrix(0.00425532 0 0 0.00190238 0 -0.00508135)""/>
</pattern>
<image id=""image0_269_694"" width=""235"" height=""531"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5DCA6C16-F112-4517-8655-3B03CFB7A716"),
                         Id = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                         Title = "Sóc phản vệ",
                         Image = @"<svg width=""75"" height=""75"" viewBox=""0 0 75 75"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M17.128 21.6094C17.7894 20.7886 18.9601 20.5913 19.8542 21.1501L28.1876 26.3584C28.7967 26.739 29.1667 27.4067 29.1667 28.1251C29.1667 28.8434 28.7967 29.5111 28.1876 29.8917L19.8542 35.1001C18.9473 35.6669 17.7586 35.4549 17.1034 34.6097C16.4482 33.7645 16.5396 32.5603 17.3146 31.8234C19.3613 29.8778 19.7596 28.8601 19.7546 28.2209C19.7494 27.5332 19.2851 26.4497 17.2584 24.3711C16.5223 23.6161 16.4663 22.4303 17.128 21.6094Z"" fill=""#F23929""/>
<path d=""M55.1459 21.1501C56.04 20.5913 57.2107 20.7886 57.8721 21.6094C58.5338 22.4303 58.4777 23.6161 57.7417 24.3711C55.715 26.4497 55.2507 27.5332 55.2455 28.2209C55.2405 28.8601 55.6388 29.8778 57.6855 31.8234C58.4607 32.5603 58.5519 33.7645 57.8967 34.6097C57.2415 35.4549 56.0528 35.6669 55.1459 35.1001L46.8125 29.8917C46.2034 29.5111 45.8334 28.8434 45.8334 28.1251C45.8334 27.4067 46.2034 26.739 46.8125 26.3584L55.1459 21.1501Z"" fill=""#F23929""/>
<path d=""M56.7878 52.0833C53.2047 44.6631 45.9128 39.5833 37.5001 39.5833C29.0874 39.5833 21.7955 44.6631 18.2124 52.0833C17.2355 54.106 18.8714 56.25 21.1174 56.25H53.8828C56.1289 56.25 57.7647 54.106 56.7878 52.0833Z"" fill=""#F23929""/>
<path d=""M41.6667 13.5417C41.6667 15.2675 40.2675 16.6667 38.5417 16.6667C36.8159 16.6667 35.4167 15.2675 35.4167 13.5417C35.4167 11.8158 36.8159 10.4167 38.5417 10.4167C40.2675 10.4167 41.6667 11.8158 41.6667 13.5417Z"" fill=""#F23929""/>
<path d=""M66.6667 44.7917C66.6667 46.5175 65.2675 47.9167 63.5417 47.9167C61.8159 47.9167 60.4167 46.5175 60.4167 44.7917C60.4167 43.0658 61.8159 41.6667 63.5417 41.6667C65.2675 41.6667 66.6667 43.0658 66.6667 44.7917Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M37.5 75C58.2106 75 75 58.2106 75 37.5C75 16.7894 58.2106 0 37.5 0C16.7894 0 0 16.7894 0 37.5C0 58.2106 16.7894 75 37.5 75ZM37.5 70.8333C55.9096 70.8333 70.8333 55.9096 70.8333 37.5C70.8333 27.7827 66.6754 19.0367 60.0417 12.944C59.5131 13.9202 58.4798 14.5833 57.2917 14.5833C55.5658 14.5833 54.1667 13.1842 54.1667 11.4583C54.1667 10.5723 54.5354 9.7725 55.1277 9.20375C50.0142 6.01142 43.9725 4.16667 37.5 4.16667C31.9425 4.16667 26.7027 5.52671 22.0952 7.93212C22.6112 8.62583 22.9167 9.48562 22.9167 10.4167C22.9167 12.7179 21.0512 14.5833 18.75 14.5833C17.2829 14.5833 15.9927 13.825 15.2504 12.679C8.44687 18.7817 4.16667 27.641 4.16667 37.5C4.16667 39.6237 4.36527 41.701 4.74492 43.7144C5.47029 42.4888 6.80581 41.6667 8.33333 41.6667C10.6346 41.6667 12.5 43.5321 12.5 45.8333C12.5 48.1346 10.6346 50 8.33333 50C7.63642 50 6.97946 49.829 6.40219 49.5265C10.2637 59.5048 18.7894 67.1602 29.305 69.8185C29.2148 69.4775 29.1667 69.1194 29.1667 68.75C29.1667 66.4487 31.0321 64.5833 33.3333 64.5833C35.6346 64.5833 37.5 66.4487 37.5 68.75C37.5 69.5071 37.2981 70.2169 36.9452 70.8287C37.1298 70.8319 37.3148 70.8333 37.5 70.8333Z"" fill=""#F23929""/>
</svg>
"
                     },
            #endregion
                     //Ưu tiên            Id = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
            #region Ưu tiên
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
                         Id = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                         Title = "Cầm máu",
                         Image = @"<svg width=""86"" height=""87"" viewBox=""0 0 86 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.925934"" y=""0.759247"" width=""84.4079"" height=""85.463"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_718"" transform=""matrix(0.00201207 0 0 0.00198723 0 -0.0027697)""/>
</pattern>
<image id=""image0_269_718"" width=""497"" height=""506"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
                         Id = Guid.Parse("1F7BFE1C-B663-4F08-9713-83394F85319D"),
                         Title = "Gãy xương",
                         Image = @"<svg width=""82"" height=""83"" viewBox=""0 0 82 83"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
<rect x=""0.240753"" y=""0.703705"" width=""81.5185"" height=""81.5185"" fill=""url(#pattern0)""/>
<defs>
<pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1"" height=""1"">
<use xlink:href=""#image0_269_722"" transform=""translate(-0.00102669) scale(0.00205339)""/>
</pattern>
<image id=""image0_269_722"" width=""488"" height=""487"" xlink:href=""data:image/png;base64,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""/>
</defs>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
                         Id = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                         Title = "Trụy tim",
                         Image = @"<svg width=""70"" height=""78"" viewBox=""0 0 70 78"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M29.2051 0H37.7936V5.67667C40.5254 5.51031 43.1733 5.66937 45.5525 6.17163C35.4601 10.1439 30.8167 20.3523 30.0564 22.0241L30.0096 22.1265C27.5434 21.752 24.8715 21.4407 22.3433 21.4639C19.7379 21.6859 17.2101 22.0709 13.047 24.4158C12.46 24.8306 11.6685 25.511 10.593 26.5485C10.5149 26.4922 10.4311 26.4401 10.3216 26.3716C10.234 26.3168 10.1295 26.2518 9.99806 26.1659C9.40352 25.7775 8.53543 25.2518 7.47689 24.7269C5.2963 23.6449 2.62142 22.7223 0 22.7223V14.3951C4.53272 14.3951 8.60801 15.9339 11.389 17.3137C12.3537 17.7923 13.2003 18.2706 13.9009 18.6958C14.5208 17.3727 15.3386 16.1422 16.3164 15.0076L11.6 7.60671L19.1601 2.69719L23.5113 9.52535C25.3033 8.60122 27.2254 7.83439 29.2051 7.23173V0Z"" fill=""#F23929""/>
<path d=""M52.3006 18.661C49.1707 20.1118 46.4615 22.4967 44.0189 27.0872C44.0189 27.0872 38.5997 24.609 34.2032 23.321C37.5775 16.4802 41.5039 12.6312 47.2941 9.94729C52.8951 7.35103 59.577 6.68626 67.5148 6.96055L67.139 17.1776C59.8149 16.9244 55.6194 17.1226 52.3006 18.661Z"" fill=""#F23929""/>
<path d=""M14.7778 28.384C-0.816175 42.2932 21.4607 77.0661 39.2826 77.0661C57.1043 77.0661 81.6444 42.3241 63.7875 26.3971C63.3755 26.0295 63.0147 25.6988 62.6798 25.3918C61.2038 24.0384 60.2215 23.1379 57.4981 21.5186C52.018 21.5186 48.7154 27.0004 47.212 30.3401C47.1356 30.5097 47.0413 30.6679 46.9322 30.8131L43.4663 40.455L42.2173 44.9387C42.0855 45.4121 42.1199 45.9163 42.315 46.3674L43.7738 49.7388L51.3274 48.8621L51.8226 53.1276L44.7183 53.9524L45.18 60.7197L40.8958 61.0119L40.3197 52.5698L38.374 48.0726C37.7884 46.7195 37.6849 45.2064 38.0805 43.7863L38.1178 43.6523L33.7505 45.6273L30.8951 52.8455L26.9018 51.2659L29.1634 45.5493L22.27 43.9252L23.2547 39.7454L31.855 41.7717L39.7061 38.2209L42.3462 30.8766C35.544 27.6808 21.5754 22.3207 14.7778 28.384Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
                         Id = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                         Title = "Co giật",
                         Image = @"<svg width=""88"" height=""88"" viewBox=""0 0 88 88"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M24.5058 7.74791C25.2894 7.10675 26.4444 7.22225 27.0857 8.00589L34.419 16.9689C34.8674 17.5171 34.96 18.2747 34.6568 18.9148C34.3534 19.555 33.7084 19.9631 33 19.9631H30.0901L32.5736 22.5686C33.2721 23.3016 33.2442 24.4621 32.5112 25.1606C31.7783 25.8591 30.6178 25.8312 29.9193 25.0984L24.4831 19.3946C23.9771 18.8636 23.8361 18.0822 24.1248 17.4079C24.4138 16.7337 25.0767 16.2965 25.8102 16.2965H29.1313L24.2479 10.3278C23.6066 9.54412 23.7221 8.38908 24.5058 7.74791Z"" fill=""#F23929""/>
<path d=""M44.0001 42.1667C48.0501 42.1667 51.3334 38.8835 51.3334 34.8333C51.3334 30.7833 48.0501 27.5 44.0001 27.5C39.95 27.5 36.6667 30.7833 36.6667 34.8333C36.6667 38.8835 39.95 42.1667 44.0001 42.1667Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M54.9999 51.9729C55.6887 52.1159 56.429 52.2677 57.1673 52.4138C58.5304 52.6838 59.9551 52.9491 61.0641 53.1066C61.5943 53.1819 62.1839 53.2523 62.6965 53.2657C62.9097 53.2712 63.3693 53.2775 63.8751 53.1724C64.1023 53.1253 64.6724 52.9926 65.2703 52.5892C65.9725 52.1155 66.9166 51.0874 66.9166 49.5002C66.9166 49.0848 66.8422 48.7346 66.8279 48.6672L66.8262 48.6595C66.7987 48.5266 66.7674 48.4012 66.7415 48.3025C66.6885 48.1007 66.6205 47.8677 66.5485 47.6293C66.402 47.1453 66.2 46.5143 65.9671 45.8041C65.4995 44.3772 64.8798 42.5455 64.2647 40.7472C63.6487 38.9457 63.0331 37.1652 62.5718 35.8359C62.3412 35.1711 62.1488 34.6185 62.0141 34.2321L61.802 33.6239C61.1337 31.7123 59.0424 30.7044 57.1308 31.3726C55.2192 32.0409 54.2114 34.1327 54.8797 36.0443L54.8802 36.0461L55.0892 36.6451C55.2231 37.029 55.4143 37.5784 55.6438 38.2399C56.1029 39.5634 56.7147 41.3327 57.3259 43.1201C57.5541 43.7872 57.7815 44.4551 58.0006 45.1021C56.8947 44.8791 55.8103 44.6509 54.9253 44.4646L54.87 44.4529C54.3509 44.3436 53.8921 44.2472 53.5522 44.1781C53.3842 44.144 53.2251 44.1123 53.0933 44.0881C53.0297 44.0763 52.9486 44.062 52.8654 44.0494C52.8245 44.0431 52.7616 44.034 52.6879 44.0255L52.6859 44.0254C52.639 44.02 52.4661 44.0002 52.2499 44.0002C51.3751 44.0002 50.6971 44.329 50.6406 44.3565L50.6372 44.3581C50.4408 44.447 50.2718 44.5411 50.1781 44.5941C50.0366 44.6742 49.8527 44.7847 49.7012 44.8757L49.5791 44.9488C49.1842 45.1846 48.7085 45.4601 48.1398 45.7304C46.9874 46.2782 45.5636 46.7502 43.9999 46.7502C42.4357 46.7502 41.0096 46.278 39.8559 45.73C39.287 45.4598 38.8111 45.1844 38.4186 44.9495L38.2902 44.8725C38.1412 44.7829 37.9617 44.6749 37.8253 44.5975C37.7334 44.5453 37.5653 44.4514 37.3719 44.3629C37.3418 44.3478 36.6477 44.0002 35.7499 44.0002C35.5248 44.0002 35.3444 44.0217 35.2973 44.0274L35.2945 44.0277C35.2194 44.0365 35.1556 44.0463 35.1143 44.0529C35.0305 44.0661 34.9493 44.0811 34.8859 44.093C34.7546 44.1181 34.5955 44.1506 34.4283 44.1858C34.1082 44.2529 33.6801 44.3453 33.1963 44.45L33.1138 44.4679C32.2408 44.6566 31.1657 44.8889 30.0655 45.1155C30.2632 44.5589 30.4672 43.9869 30.6729 43.4127C31.1912 41.9663 31.7333 40.4672 32.1947 39.1916L32.1964 39.1868C32.8091 37.4932 33.2792 36.1937 33.36 35.9374C33.9696 34.0064 32.8984 31.9466 30.9673 31.337C29.0363 30.7273 26.9765 31.7985 26.3669 33.7297C26.3704 33.7187 26.3702 33.7191 26.3644 33.736C26.357 33.7572 26.3407 33.8049 26.3108 33.8894C26.2659 34.0168 26.2043 34.189 26.1273 34.4033C25.9737 34.8312 25.7656 35.4063 25.5203 36.0845L25.4198 36.362C24.9457 37.6721 24.3543 39.3064 23.7693 40.9397C23.143 42.6876 22.5177 44.4523 22.0471 45.8305C21.8128 46.5159 21.6083 47.1307 21.4595 47.6092C21.3861 47.8446 21.3156 48.0809 21.26 48.2913C21.2327 48.3946 21.1995 48.5271 21.1705 48.6694L21.1691 48.6771C21.1517 48.7623 21.0833 49.0967 21.0833 49.5002C21.0833 50.8928 21.8236 51.9019 22.5296 52.4508C23.1227 52.9123 23.7097 53.0833 23.9682 53.1489C24.5162 53.2879 25.0141 53.2905 25.2385 53.2886C25.7786 53.2842 26.3899 53.2146 26.9241 53.1405C28.0468 52.9852 29.4825 52.7152 30.8478 52.44C31.5809 52.2922 32.3156 52.1386 32.9999 51.993V59.1581C32.8197 59.2622 32.6476 59.3821 32.4859 59.5168L26.9859 64.1002C25.9708 64.9461 25.4893 66.2729 25.7256 67.5729L27.559 77.6562C27.9099 79.586 29.7174 80.8979 31.6609 80.6335C33.6044 80.369 34.9957 78.6218 34.8181 76.6684L34.0917 68.6787L34.2296 68.5803C41.9508 67.1021 46.2482 67.0927 53.7635 68.5757L53.9078 68.6787L53.1815 76.6684C53.0038 78.6218 54.3951 80.369 56.3386 80.6335C58.2822 80.8979 60.0896 79.586 60.4406 77.6562L62.2739 67.5729C62.5102 66.2729 62.0289 64.9461 61.0136 64.1002L55.5136 59.5168C55.3521 59.3821 55.1802 59.2624 54.9999 59.1582V51.9729ZM62.8866 45.9348L62.8745 45.9344C62.9055 45.9342 62.9115 45.9355 62.8866 45.9348Z"" fill=""#F23929""/>
<path d=""M60.9144 8.00589C61.5557 7.22225 62.7107 7.10675 63.4942 7.74791C64.278 8.38908 64.3935 9.54412 63.7522 10.3278L58.8687 16.2965H62.1898C62.9233 16.2965 63.5863 16.7337 63.8752 17.4079C64.164 18.0822 64.023 18.8636 63.517 19.3946L58.0808 25.0984C57.3823 25.8312 56.2218 25.8591 55.4888 25.1606C54.7558 24.4621 54.728 23.3016 55.4265 22.5686L57.9099 19.9631H55C54.2916 19.9631 53.6467 19.555 53.3433 18.9148C53.04 18.2747 53.1326 17.5171 53.581 16.9689L60.9144 8.00589Z"" fill=""#F23929""/>
<path d=""M43.0601 7.71898C44.0316 7.32758 45.1083 7.74712 45.4651 8.65605L47.9729 15.0462C48.2133 15.6586 48.0703 16.3669 47.6017 16.8845C47.1331 17.4021 46.4164 17.6435 45.7416 17.511L43.9995 17.1691L45.3709 20.3689C45.7555 21.2661 45.2884 22.332 44.3275 22.7495C43.3667 23.1669 42.276 22.7779 41.8916 21.8806L39.1414 15.4639C38.8787 14.8509 39.0077 14.1296 39.4752 13.5986C39.9427 13.0677 40.6691 12.8176 41.3533 12.9519L43.2206 13.3185L41.9469 10.0734C41.5904 9.16451 42.0887 8.11038 43.0601 7.71898Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("93AEDA91-AE3C-448A-BB89-497F28256563"),
                         Id = Guid.Parse("52A8AEF1-343C-41E0-A97B-6E63FC1AFB5D"),
                         Title = "Hạ đường huyết",
                         Image = @"<svg width=""45"" height=""72"" viewBox=""0 0 45 72"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M19.7999 14.4C23.7763 14.4 26.9999 11.1764 26.9999 7.19999C26.9999 3.22354 23.7763 0 19.7999 0C15.8236 0 12.6 3.22354 12.6 7.19999C12.6 11.1764 15.8236 14.4 19.7999 14.4Z"" fill=""#F23929""/>
<path d=""M33.2999 8.99998C34.791 8.99998 35.9999 7.61615 35.9999 5.90908C35.9999 3.20454 33.2999 0 33.2999 0C33.2999 0 30.5999 3.20454 30.5999 5.90908C30.5999 7.61615 31.8088 8.99998 33.2999 8.99998Z"" fill=""#F23929""/>
<path d=""M45 19.691C45 21.7394 43.3883 23.4001 41.4 23.4001C39.4117 23.4001 37.8 21.7394 37.8 19.691C37.8 18.3093 38.4525 16.8188 39.2019 15.5627L39.2643 15.459C39.3266 15.3564 39.3894 15.2555 39.4526 15.1563C40.3989 13.6695 41.4 12.6001 41.4 12.6001C41.4 12.6001 42.5871 13.8682 43.598 15.5627C43.6324 15.6201 43.6664 15.6781 43.7004 15.7366C44.4058 16.955 45 18.3725 45 19.691Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M36.4085 22.217C35.2366 20.2105 33.1289 18 29.8 18H9.7999C6.47099 18 4.36337 20.2105 3.19139 22.217C2.02374 24.2161 1.34244 26.6824 0.914758 28.9079C0.0467994 33.4236 0 38.2085 0 39.5999C0 41.5882 1.61172 43.1999 3.59999 43.1999C5.58827 43.1999 7.19999 41.5882 7.19999 39.5999C7.19999 38.2913 7.25309 34.0763 7.98533 30.2669C8.26361 28.8185 8.60993 27.599 8.99998 26.677V68.3999C8.99998 70.3343 10.5287 71.923 12.4617 71.9972C14.3949 72.0715 16.041 70.6047 16.1894 68.676L17.9893 45.276C17.9964 45.1839 18 45.0917 18 44.9999H21.6C21.6 45.0917 21.6036 45.1839 21.6106 45.276L23.4106 68.676C23.5589 70.6047 25.205 72.0715 27.1382 71.9972C29.0712 71.923 30.5999 70.3343 30.5999 68.3999V26.677C30.99 27.599 31.3363 28.8185 31.6146 30.2669C32.3468 34.0763 32.3999 38.2913 32.3999 39.5999C32.3999 41.5882 34.0117 43.1999 35.9999 43.1999C37.9882 43.1999 39.5999 41.5882 39.5999 39.5999C39.5999 38.2085 39.5531 33.4236 38.6852 28.9079C38.2575 26.6824 37.5762 24.2161 36.4085 22.217ZM16.2 35.9999C18.1882 35.9999 19.8 34.3393 19.8 32.2909C19.8 29.0455 16.2 25.2 16.2 25.2C16.2 25.2 12.6 29.0455 12.6 32.2909C12.6 34.3393 14.2117 35.9999 16.2 35.9999Z"" fill=""#F23929""/>
</svg>
"
                     },
            #endregion
                     // Thương tích             Id = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
            #region Thương tích
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("1F04BEFB-E7A8-4C34-87FE-5A61795FDC2A"),
                         Title = "Động vật cắn",
                         Image = @"<svg width=""80"" height=""69"" viewBox=""0 0 80 69"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M71.9605 1.39142C72.8156 2.24666 72.8156 3.63326 71.9605 4.48851L49.4194 27.0296H43.2255L35.5606 34.6944H15.2721C14.5672 32.4129 14.0164 29.8369 13.7186 26.9139C12.992 26.9514 12.1832 26.9691 11.2831 26.9691C8.73471 26.9691 4.80191 26.7972 3.61826 25.9346C1.42834 23.0333 0.333313 17.2356 0.333313 17.2356C0.333313 17.2356 6.4367 15.1532 9.09317 14.2117C9.09295 7.15148 18.2203 3.12221 22.8593 9.07077C24.0119 9.06595 25.3252 9.43649 26.5553 10.1914C28.7801 11.5566 29.6236 17.7159 29.1408 20.5024C32.6554 24.6421 37.1514 26.341 43.0374 26.9691L43.2623 26.9926L68.8634 1.39142C69.7186 0.536194 71.1053 0.536194 71.9605 1.39142Z"" fill=""#F23929""/>
<path d=""M49.1622 27.2865L38.6576 37.7911V52.4958C44.6402 51.6973 49.7553 50.4561 56.1773 46.7388C60.8586 55.3211 64.7808 57.7883 66.7936 59.0543C67.6059 59.5652 68.1072 59.8806 68.2221 60.3232C68.4836 61.3299 68.7602 62.0681 68.9764 62.645C69.2462 63.365 69.4218 63.8337 69.3559 64.2585H68.2221C67.0126 64.2585 66.0322 65.239 66.0322 66.4485C66.0322 67.658 67.0126 68.6385 68.2221 68.6385H72.6021C73.8116 68.6385 74.792 67.658 74.792 66.4485V56.5435C74.792 52.2137 68.2221 40.6689 68.2221 40.6689L78.077 53.3087C78.9639 53.863 80.162 52.7982 79.172 51.1188C78.7585 50.015 78.3069 48.569 77.7956 46.9322C75.3557 39.121 71.5599 26.9687 64.1024 26.9687C63.0236 26.9687 61.4711 27.0241 59.6438 27.0894C56.6061 27.1978 52.8083 27.3333 49.1622 27.2865Z"" fill=""#F23929""/>
<path d=""M34.1259 53.0276C34.1765 53.0223 34.2271 53.0168 34.2774 53.0114V39.0744H16.9465C18.714 42.913 20.8295 45.6927 22.4698 47.8479C22.7736 48.2471 23.0615 48.6255 23.3276 48.9847C24.3764 50.4009 27.4347 59.5081 22.8785 64.259H22.2326C21.0231 64.259 20.0427 65.2395 20.0427 66.449C20.0427 67.6585 21.0231 68.6389 22.2326 68.6389H28.8025C29.8123 68.6389 30.6627 67.9554 30.9158 67.0258L30.9204 67.0254C30.9312 67.0245 30.941 67.0219 30.95 67.0173C31.0435 66.9702 31.0354 66.721 31.017 66.159C31.0065 65.836 30.9925 65.4098 30.9925 64.8593V53.3646C31.6898 53.2884 32.37 53.2157 33.0353 53.1445L33.0508 53.1428C33.3099 53.1152 33.5668 53.0878 33.8215 53.0604C33.9233 53.0495 34.0247 53.0385 34.1259 53.0276Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("C813800B-BA50-4270-B3A6-9313E7884646"),
                         Title = "Con trùng cắn",
                         Image = @"<svg width=""67"" height=""69"" viewBox=""0 0 67 69"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M17.1329 0.786983C16.1262 0.582734 15.1467 1.24506 14.9454 2.26632L12.1568 16.4097C12.052 16.9419 12.178 17.494 12.503 17.9249L23.8022 32.9133C23.5848 33.5577 23.3895 34.2256 23.2177 34.9147C23.1493 34.8779 23.0781 34.8451 23.0039 34.8166L11.1182 30.2496L3.22531 22.0614C2.50751 21.3167 1.33051 21.3033 0.596393 22.0314C-0.137701 22.7595 -0.150937 23.9534 0.566853 24.6981L8.74661 33.1841C8.93567 33.3802 9.16452 33.532 9.41735 33.6293L21.687 38.3438C21.9786 38.4558 22.2807 38.4886 22.5702 38.4526C22.4953 39.0741 22.4384 39.707 22.4006 40.3493L12.1001 39.4164C11.4614 39.3585 10.8382 39.6387 10.4515 40.1579L4.13088 48.6439C3.51195 49.4748 3.67428 50.6573 4.49346 51.2853C5.31264 51.9131 6.47846 51.7485 7.09741 50.9174L12.7965 43.266L22.1802 44.1158C22.2543 44.1226 22.3278 44.1248 22.4004 44.1226C22.4192 44.4409 22.4425 44.7567 22.4703 45.0702C22.1246 45.0462 21.7682 45.1199 21.4427 45.3034L13.077 50.0179C12.6911 50.2353 12.394 50.5849 12.2392 51.0043L6.66202 66.0906C6.30152 67.0657 6.7886 68.1527 7.74998 68.5183C8.71129 68.884 9.78283 68.3899 10.1433 67.4148L15.4804 52.978L23.0234 48.7271C24.5882 55.9449 28.6881 61.0953 33.4996 61.0953C38.3111 61.0953 42.4111 55.9449 43.9758 48.7271L51.5188 52.978L56.8559 67.4148C57.2164 68.3899 58.2879 68.884 59.2492 68.5183C60.2105 68.1527 60.6976 67.0657 60.3371 66.0906L54.76 51.0043C54.6052 50.5849 54.3081 50.2353 53.9222 50.0179L45.5565 45.3034C45.231 45.1199 44.8746 45.0462 44.5289 45.0702C44.5568 44.7567 44.58 44.4409 44.5988 44.1226C44.6715 44.1248 44.7449 44.1226 44.8191 44.1158L54.2027 43.266L59.9017 50.9174C60.5208 51.7485 61.6866 51.9131 62.5057 51.2853C63.325 50.6573 63.4873 49.4748 62.8684 48.6439L56.5477 40.1579C56.161 39.6387 55.5379 39.3585 54.8991 39.4164L44.5986 40.3493C44.5608 39.707 44.504 39.0741 44.429 38.4526C44.7185 38.4886 45.0206 38.4558 45.3123 38.3438L57.5819 33.6293C57.8347 33.532 58.0635 33.3802 58.2526 33.1841L66.4323 24.6981C67.1501 23.9534 67.1369 22.7595 66.4028 22.0314C65.6686 21.3033 64.4917 21.3167 63.7739 22.0614L55.881 30.2496L43.9953 34.8166C43.9211 34.8451 43.8499 34.8779 43.7815 34.9147C43.6098 34.2256 43.4144 33.5577 43.1971 32.9133L54.4962 17.9249C54.8212 17.494 54.9472 16.9419 54.8424 16.4097L52.0538 2.26632C51.8525 1.24506 50.873 0.582734 49.8663 0.786983C48.8595 0.991232 48.2066 1.98472 48.4079 3.00598L51.0314 16.3122L41.4537 29.0171C40.7502 27.8075 39.951 26.7575 39.0767 25.9025V18.6653C39.0767 17.6238 38.2444 16.7795 37.2177 16.7795C36.1909 16.7795 35.3586 17.6238 35.3586 18.6653V19.6082H31.6406V18.6653C31.6406 17.6238 30.8083 16.7795 29.7815 16.7795C28.7548 16.7795 27.9225 17.6238 27.9225 18.6653V25.9025C27.0482 26.7575 26.249 27.8075 25.5456 29.0171L15.9678 16.3122L18.5913 3.00598C18.7926 1.98472 18.1397 0.991232 17.1329 0.786983Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                         Title = "Kim tim dâm",
                         Image = @"<svg width=""69"" height=""70"" viewBox=""0 0 69 70"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M0.739996 14.1105C-0.14787 14.9984 -0.14787 16.4379 0.739996 17.3258C1.62786 18.2137 3.06736 18.2137 3.95523 17.3258L5.56387 15.7172L13.601 23.7543L7.17052 30.1849C6.28258 31.0728 6.28258 32.5123 7.17052 33.4002C8.05825 34.2881 9.49771 34.2881 10.3856 33.4002L13.6002 30.1855L40.9305 57.5164C44.2264 60.8125 49.0431 61.6615 53.1221 60.0631L55.3986 62.3396C56.5892 63.5301 58.2754 63.9225 59.7927 63.5167L65.045 68.7692C65.9327 69.6572 67.3722 69.6572 68.2601 68.7692C69.148 67.8813 69.148 66.4418 68.2601 65.5539L63.007 60.3006C63.4116 58.784 63.019 57.0989 61.8293 55.909L59.553 53.6327C61.1516 49.5532 60.3028 44.7361 57.0067 41.4398L29.6763 14.1089L32.8922 10.893C33.7802 10.0051 33.7802 8.56562 32.8922 7.67769C32.0045 6.78985 30.5649 6.78985 29.6771 7.67769L23.2465 14.1083L15.2096 6.07117L16.8161 4.46454C17.704 3.57665 17.704 2.13711 16.8161 1.24923C15.9283 0.361342 14.4889 0.361342 13.601 1.24923L0.739996 14.1105ZM20.4678 16.8872L12.4309 8.84993L8.34257 12.9382L16.3797 20.9755L20.4678 16.8872ZM26.8976 16.8878L16.3789 27.4068L25.0361 36.0642L35.5548 25.545L26.8976 16.8878ZM28.2512 39.2795L33.0742 44.1024C35.8515 46.8798 33.8051 44.8334 36.2895 47.3178L39.5038 50.5323C41.6646 52.6929 41.1714 52.1999 42.7191 53.7476L43.7092 54.7377C45.8669 56.8953 49.0203 57.4502 51.6901 56.4023L55.8926 52.1999C56.9405 49.5298 56.3856 46.3764 54.228 44.2188L38.77 28.7603L28.2512 39.2795ZM59.105 58.7502C59.0885 58.7283 59.0702 58.7075 59.0506 58.6879L57.4313 57.0684C57.2945 57.2207 57.1531 57.37 57.0067 57.5164C56.8601 57.663 56.7106 57.8047 56.5581 57.9416L58.1774 59.5609C58.1974 59.5807 58.2184 59.599 58.2402 59.6157C58.3395 59.4394 58.4642 59.2734 58.6144 59.1233C58.7641 58.9738 58.9293 58.8492 59.105 58.7502Z"" fill=""#F23929""/>
<path d=""M5.5639 12.9376L4.1745 14.3269L2.56587 15.9358C2.44534 16.0562 2.24995 16.0562 2.12941 15.9358C2.00887 15.8151 2.00887 15.6196 2.12941 15.499L14.9903 2.63783C15.1108 2.51731 15.3063 2.51729 15.4267 2.63783C15.5474 2.75838 15.5474 2.95386 15.4267 3.07443L13.8203 4.68104L12.4309 6.0704L11.0415 7.45982L6.95322 11.5482L5.5639 12.9376ZM14.9903 25.1429L16.3797 23.7536L17.7691 22.364L21.8574 18.2757L23.2465 16.8864L24.6359 15.497L31.0665 9.06638C31.187 8.94573 31.3825 8.94573 31.5029 9.06638C31.6236 9.18682 31.6236 9.38233 31.5029 9.50297L28.287 12.7189L26.8977 14.1082L25.5083 15.4976L14.9896 26.0167L13.6002 27.4061L12.2108 28.7954L8.99631 32.0102C8.87587 32.1306 8.68036 32.1306 8.55992 32.0102C8.43927 31.8895 8.43927 31.694 8.55992 31.5736L14.9903 25.1429ZM30.2955 44.1022L25.1576 38.964L25.426 38.6958L23.6436 37.3324C23.3776 37.1288 23.1194 36.9088 22.8705 36.6722C23.2837 37.0648 23.725 37.4136 24.1881 37.7179L25.5252 38.5966L26.6564 37.4652L36.9566 27.1646L38.088 26.0334L37.2095 24.6963C36.9081 24.2377 36.563 23.8005 36.1752 23.3909C36.4074 23.6361 36.6236 23.8901 36.8238 24.1519L38.1872 25.9342L38.455 25.6664L55.6172 42.8287C58.3415 45.553 59.0474 49.5366 57.7235 52.915L57.2543 54.112L58.1634 55.0211L60.4397 57.2976C61.1137 57.9716 61.3398 58.9265 61.1086 59.7934L60.8166 60.888L61.6177 61.6893L66.8708 66.9426C66.9914 67.063 66.9914 67.2585 66.8708 67.3792C66.7503 67.4996 66.5548 67.4996 66.4344 67.3792L61.1821 62.1267L60.3804 61.325L59.2852 61.6178C58.4179 61.8498 57.4624 61.6239 56.7882 60.9495L54.5117 58.673L53.6026 57.7639L52.4054 58.2331C49.1936 59.4916 45.435 58.9155 42.7314 56.5146L47.761 51.485C49.416 49.8298 49.416 47.1461 47.761 45.4909C46.1058 43.8357 43.4222 43.8357 41.767 45.4909L36.7257 50.5324L36.2895 50.0962L41.331 45.0545C42.9862 43.3993 42.9862 40.7157 41.331 39.0605C39.6758 37.4053 36.9922 37.4053 35.337 39.0605L30.2955 44.1022Z"" fill=""#F23929""/>
<path d=""M14.9903 2.63783L2.12941 15.499C2.00887 15.6196 2.00887 15.8151 2.12941 15.9358C2.24995 16.0562 2.44534 16.0562 2.56587 15.9358L4.1745 14.3269L5.5639 12.9376L6.95322 11.5482L11.0415 7.45982L12.4309 6.0704L13.8203 4.68104L15.4267 3.07443C15.5474 2.95386 15.5474 2.75838 15.4267 2.63783C15.3063 2.51729 15.1108 2.51731 14.9903 2.63783ZM14.9903 2.63783L13.601 1.24847M47.761 45.4909C49.416 47.1461 49.416 49.8298 47.761 51.485L42.7314 56.5146C45.435 58.9155 49.1936 59.4916 52.4054 58.2331L53.6026 57.7639L54.5117 58.673L56.7882 60.9495C57.4624 61.6239 58.4179 61.8498 59.2852 61.6178L60.3804 61.325L61.1821 62.1267L66.4344 67.3792C66.5548 67.4996 66.7503 67.4996 66.8708 67.3792C66.9914 67.2585 66.9914 67.063 66.8708 66.9426L61.6177 61.6893L60.8166 60.888L61.1086 59.7934C61.3398 58.9265 61.1137 57.9716 60.4397 57.2976L58.1634 55.0211L57.2543 54.112L57.7235 52.915C59.0474 49.5366 58.3415 45.553 55.6172 42.8287L38.455 25.6664L38.1872 25.9342L36.8238 24.1519C36.6236 23.8901 36.4074 23.6361 36.1752 23.3909C36.563 23.8005 36.9081 24.2377 37.2095 24.6963L38.088 26.0334L36.9566 27.1646L26.6564 37.4652L25.5252 38.5966L24.1881 37.7179C23.725 37.4136 23.2837 37.0648 22.8705 36.6722C23.1194 36.9088 23.3776 37.1288 23.6436 37.3324L25.426 38.6958L25.1576 38.964L30.2955 44.1022L35.337 39.0605C36.9922 37.4053 39.6758 37.4053 41.331 39.0605C42.9862 40.7157 42.9862 43.3993 41.331 45.0545L36.2895 50.0962L36.7257 50.5324L41.767 45.4909C43.4222 43.8357 46.1058 43.8357 47.761 45.4909ZM47.761 45.4909L46.3717 46.8803M14.9903 25.1429L16.3797 23.7536L17.7691 22.364L21.8574 18.2757L23.2465 16.8864L24.6359 15.497L31.0665 9.06638C31.187 8.94573 31.3825 8.94573 31.5029 9.06638C31.6236 9.18682 31.6236 9.38233 31.5029 9.50297L28.287 12.7189L26.8977 14.1082L25.5083 15.4976L14.9896 26.0167L13.6002 27.4061L12.2108 28.7954L8.99631 32.0102C8.87587 32.1306 8.68036 32.1306 8.55992 32.0102C8.43927 31.8895 8.43927 31.694 8.55992 31.5736L14.9903 25.1429Z"" stroke=""#F23929"" stroke-width=""2""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                         Title = "Giẫm đinh",
                         Image = @"<svg width=""44"" height=""86"" viewBox=""0 0 44 86"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M15.6643 72.5042L15.6643 25.8657L21.979 0.42658L28.2937 25.8657L28.2937 72.5042L15.6643 72.5042ZM0.930061 85.2238L43.028 85.2238L43.028 76.7441L0.930062 76.7441L0.930061 85.2238Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("6A30DBFE-0C1C-4D34-B968-52BF9DABB48E"),
                         Title = "Bong gân",
                         Image = @"<svg width=""81"" height=""86"" viewBox=""0 0 81 86"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M59.5702 19.3303C59.5702 29.7453 51.1272 38.1883 40.7122 38.1883C30.2971 38.1883 21.8542 29.7453 21.8542 19.3303C21.8542 8.91525 30.2971 0.472229 40.7122 0.472229C51.1272 0.472229 59.5702 8.91525 59.5702 19.3303ZM22.3548 59.4297C22.1903 59.4125 22.0234 59.4036 21.8542 59.4036C19.2503 59.4036 17.1397 61.5142 17.1397 64.1181C17.1397 64.6216 17.2186 65.1065 17.3648 65.5614L22.3548 59.4297ZM42.586 69.4157C45.6315 70.6293 47.7839 73.6046 47.7839 77.083C47.7839 81.2393 44.7103 84.6778 40.7122 85.2499V85.3333H39.5336H38.9978H29.5322H26.5687H21.8542C10.1372 85.3333 0.638885 75.835 0.638885 64.1181C0.638885 52.4011 10.1372 42.9028 21.8542 42.9028H35.8056H36.9262H39.5336H50.1412H53.6832H59.5702C71.2872 42.9028 80.7855 52.4011 80.7855 64.1181C80.7855 75.835 71.2872 85.3333 59.5702 85.3333H49.5349C51.3863 83.0918 52.4985 80.2172 52.4985 77.083C52.4985 71.6464 49.1521 66.9913 44.4069 65.0652L42.586 69.4157ZM38.4391 47.6173H39.5336H46.5992L32.7859 80.6188H21.8542C18.6754 80.6188 15.7064 79.72 13.1877 78.1626L35.9263 50.2232L38.4391 47.6173ZM64.2847 64.1181C64.2847 66.7219 62.174 68.8326 59.5702 68.8326V59.4036C62.174 59.4036 64.2847 61.5142 64.2847 64.1181Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("46F2F761-1478-44FD-ADAE-FF50940EA9AA"),
                         Title = "Bỏng",
                         Image = @"<svg width=""87"" height=""87"" viewBox=""0 0 87 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M0.611084 0.759247V1.2497C12.1998 10.4377 17.7967 22.1384 16.7377 33.5708C14.8257 23.6531 9.20859 14.674 0.611264 8.52407V12.7668C10.5725 20.9128 15.4709 33.3791 13.7687 46.1698C13.6969 46.5903 13.6317 47.0108 13.5769 47.432C13.5615 47.5245 13.548 47.6159 13.5318 47.7082H13.5431C12.3615 57.4086 15.5626 67.2841 22.4854 75.8425C23.6403 77.8391 25.0065 79.774 26.5763 81.6352C14.2074 70.7038 7.68531 57.8795 6.62921 44.6938C4.62557 59.6601 9.35374 74.1227 22.9811 86.2054H31.022C31.0279 86.2105 31.0328 86.2168 31.0389 86.2222H54.5644C54.5701 86.2168 54.5752 86.2105 54.5809 86.2051H62.4471C76.0748 74.1227 80.803 59.6599 78.7997 44.6934C77.7629 57.6352 71.4615 70.2293 59.5341 81.0265C61.2576 78.9074 62.7215 76.6957 63.9121 74.4115C70.0608 66.1929 72.8551 56.8714 71.7392 47.7081C71.7384 47.7045 71.7397 47.7005 71.7392 47.6967C71.6661 47.0999 71.5751 46.5056 71.4687 45.9105C69.7801 32.523 75.3108 19.5221 86.3106 11.4933V7.40847C76.7991 13.5523 70.5855 23.005 68.5444 33.5257C67.4896 21.9482 73.2511 10.0995 85.1555 0.866353L85.0708 0.759247H80.0107C67.0184 12.3611 62.0073 27.7467 66.938 41.882C67.4532 43.3572 67.8545 44.8699 68.1383 46.4066C68.1392 46.4143 68.143 46.4215 68.1437 46.4291C68.2231 47.0485 68.312 47.6689 68.42 48.2889H68.4254C68.8408 51.7821 68.6273 55.302 67.8114 58.7751C67.8035 53.6586 66.5892 48.4703 64.1265 43.4372C56.9032 28.6764 60.3818 12.527 73.576 0.759427H67.9809C58.9391 9.16616 56.0218 17.2689 57.6237 28.0036C53.7492 17.3354 54.1229 9.32682 61.3544 0.759427H24.4405C31.6718 9.32682 32.0456 17.3356 28.1709 28.0036C29.7729 17.2687 26.8607 9.16634 17.8196 0.759427H12.0272C25.2215 12.527 28.6999 28.6764 21.4767 43.4374C18.7904 48.9275 17.5964 54.6014 17.8254 60.1668C16.7172 56.2455 16.38 52.2493 16.8506 48.2889C16.9588 47.6693 17.0531 47.0483 17.1324 46.4293C17.4169 44.8849 17.8199 43.3648 18.338 41.8823C23.2689 27.7469 18.2576 12.3615 5.26532 0.759608H0.611084V0.759247ZM42.8494 4.30925C45.8065 4.30925 47.7222 5.42358 49.1099 7.30118C50.497 9.17878 51.2677 11.9399 51.2677 15.0546C51.2677 18.42 50.0261 22.0075 48.3886 23.9801L46.563 26.1836L49.3746 26.7133C51.6325 27.1376 53.291 28.2954 54.683 30.1393C56.0746 31.983 57.1302 34.5317 57.872 37.4757C59.2283 42.8568 59.5192 49.4701 59.5624 55.3887H55.3594L55.2126 42.6766L51.8431 42.7159L52.0174 58.3016L50.62 78.4291C59.105 70.5548 63.6007 61.4252 64.3521 52.0469C65.8328 63.107 62.3416 73.7938 52.2711 82.7227H50.3209V82.7624H44.3819V57.5687H41.0124V82.762H35.3718V82.7223H33.6309C23.5601 73.7932 20.0634 63.1066 21.5442 52.0466C22.2889 61.3435 26.7119 70.3981 35.0563 78.2259L33.7771 59.7162L34.2451 42.744L30.8754 42.6485L30.5261 55.3885H26.131C26.1742 49.4695 26.4709 42.8564 27.827 37.4753C28.5692 34.5315 29.6247 31.9826 31.0167 30.1387C32.4084 28.295 34.0667 27.1372 36.3244 26.7128L39.1362 26.1832L37.3106 23.9798C35.6728 22.0072 34.431 18.4198 34.431 15.0543C34.431 11.9396 35.202 9.17842 36.5893 7.30082C37.9766 5.42376 39.8926 4.30889 42.8498 4.30889L42.8494 4.30925Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("5C43FF6A-1903-4FDC-911B-52E32CBE3633"),
                         Id = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                         Title = "Tổn thương mắt",
                         Image = @"<svg width=""115"" height=""70"" viewBox=""0 0 115 70"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M8.14029 29.8204C13.4929 23.7611 21.6165 16.8195 32.0444 12.0948C26.5799 18.1544 23.2531 26.1794 23.2531 34.9815C23.2531 43.7836 26.5799 51.8086 32.0444 57.8682C21.6165 53.1435 13.4929 46.2019 8.14029 40.1426C5.50054 37.1546 5.50054 32.8085 8.14029 29.8204ZM3.87022 26.0484C13.5786 15.0581 32.031 1.06041 56.9306 0.800029C57.0995 0.797465 57.2688 0.796326 57.4383 0.796326H57.5212H57.6368C82.8937 0.796326 101.603 14.9547 111.403 26.0484C115.946 31.1912 115.946 38.7718 111.403 43.9147C101.603 55.0083 82.8937 69.1667 57.6368 69.1667H57.5212H57.4383C57.2688 69.1667 57.0995 69.1656 56.9306 69.163C32.031 68.9026 13.5786 54.9049 3.87025 43.9147C-0.672794 38.7718 -0.672823 31.1912 3.87022 26.0484ZM57.5192 6.49386C57.3462 6.49443 57.1736 6.49528 57.0013 6.49727C41.4695 6.73059 28.9506 19.3942 28.9506 34.9815C28.9506 50.5688 41.4695 63.2324 57.0013 63.4657C57.1736 63.4677 57.3462 63.4686 57.5192 63.4692C73.2153 63.4256 85.9259 50.6879 85.9259 34.9815C85.9259 19.2751 73.2153 6.53744 57.5192 6.49386ZM91.6234 34.9815C91.6234 43.9292 88.1858 52.0738 82.5592 58.167C93.3093 53.4398 101.666 46.331 107.133 40.1426C109.773 37.1546 109.773 32.8085 107.133 29.8204C101.666 23.632 93.3093 16.5232 82.5592 11.796C88.1858 17.8892 91.6234 26.0338 91.6234 34.9815ZM57.6365 52.0741C67.0765 52.0741 74.7291 44.4215 74.7291 34.9815C74.7291 32.3427 74.1312 29.8438 73.0635 27.6123C72.0322 28.645 70.6067 29.284 69.0319 29.284C65.8851 29.284 63.3344 26.7332 63.3344 23.5864C63.3344 22.0117 63.9733 20.5861 65.006 19.5549C62.7746 18.4869 60.2753 17.8889 57.6365 17.8889C48.1966 17.8889 40.5439 25.5416 40.5439 34.9815C40.5439 44.4215 48.1966 52.0741 57.6365 52.0741Z"" fill=""#F23929""/>
</svg>
"
                     },
            #endregion
                     //Bệnh lý             Id = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
            #region Bệnh lý
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                         Title = "Sốc nhiệt",
                         Image = @"<svg width=""83"" height=""83"" viewBox=""0 0 83 83"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M47.3462 10.8935C47.3462 16.5212 42.7841 21.0833 37.1564 21.0833C31.5287 21.0833 26.9666 16.5212 26.9666 10.8935C26.9666 5.26581 31.5287 0.703674 37.1564 0.703674C42.7841 0.703674 47.3462 5.26581 47.3462 10.8935Z"" fill=""#F23929""/>
<path d=""M19.4194 26.4067C20.0329 24.6187 21.6897 23.4046 23.5699 23.3498L23.703 23.3477H50.6095L50.7427 23.3498C52.6228 23.4046 54.2797 24.6187 54.8931 26.4067L59.5551 39.9931C60.1694 41.7836 59.5976 43.7002 58.2487 44.877L57.9521 44.9759C57.0547 45.2751 55.7973 45.8278 54.5184 46.3898L54.1844 46.5368C53.0984 47.0134 51.9519 47.5125 50.8258 47.9586L50.7427 47.9914C50.3874 48.1314 50.0342 48.2659 49.6859 48.3927C48.1638 48.9461 46.9353 49.272 46.1122 49.3218C46.0495 49.3256 45.9938 49.3274 45.9447 49.3279C45.4811 47.8268 45.1532 46.1727 45.3448 44.7343C45.446 43.9762 45.6849 43.3336 46.0837 42.7983C46.477 42.2707 47.1113 41.7315 48.1871 41.301L50.2896 40.46L48.6076 36.2553L46.5051 37.0963C44.7504 37.798 43.4033 38.8159 42.4523 40.0925C41.5064 41.3617 41.0379 42.7711 40.8559 44.1358C40.5019 46.7893 41.2096 49.4613 41.8012 51.2368C42.1636 52.3237 42.9371 53.0768 43.8786 53.479C44.7273 53.8413 45.6292 53.8882 46.3862 53.8424C47.7444 53.76 49.2892 53.3298 50.7427 52.8235V77.6934C50.7427 80.0973 48.8646 82.0822 46.4643 82.2152C44.0641 82.3481 41.9783 80.5828 41.7127 78.1936L39.4483 57.814C39.4297 57.6469 39.4207 57.48 39.4207 57.3138H34.8919C34.8919 57.48 34.8828 57.6469 34.8643 57.814L32.5998 78.1936C32.3342 80.5828 30.2485 82.3481 27.8482 82.2152C25.448 82.0822 23.5699 80.0973 23.5699 77.6934V52.801C25.3325 53.3277 27.1673 53.7636 28.7257 53.8436C29.5531 53.8859 30.4958 53.8411 31.3635 53.5209C32.3084 53.1722 33.237 52.4564 33.6435 51.2368C34.3104 49.2364 34.6747 46.5083 33.9664 43.8517C33.228 41.0832 31.3436 38.5106 27.8075 37.0963L25.705 36.2553L24.0232 40.46L26.1255 41.301C28.2504 42.1511 29.1965 43.5412 29.5905 45.0185C29.9666 46.429 29.85 48.0064 29.4935 49.3193C29.3631 49.3288 29.1872 49.3324 28.9578 49.3206C27.8695 49.2649 26.3211 48.911 24.5189 48.3565C24.2048 48.2598 23.888 48.1586 23.5699 48.0542V47.9896L17.456 45.7053C15.1576 44.8466 13.9611 42.3137 14.7575 39.9931L19.4194 26.4067Z"" fill=""#F23929""/>
<path d=""M12.2479 27.8765C10.1416 27.8765 8.30569 29.0207 7.08842 30.238C5.91145 31.415 4.80778 33.1715 4.80778 34.9933C4.80778 36.2172 5.40569 37.1922 5.86718 37.8075C6.32923 38.4236 6.91245 39.0065 7.362 39.4557L7.41191 39.5058C7.7522 39.8461 8.02515 40.1217 8.24288 40.3653C7.84844 40.5603 7.38179 40.7618 6.82882 41.0007L6.82613 41.0018L6.82348 41.003C6.61622 41.0924 6.39684 41.1873 6.16456 41.2887C5.20479 41.7088 4.02135 42.2498 3.06928 42.9438C2.16268 43.605 0.925934 44.8004 0.925934 46.6386C0.925934 48.1562 1.64355 49.2628 2.45033 50.0192C3.13991 50.6656 3.99696 51.1468 4.58335 51.4761L4.66809 51.5236C5.37587 51.9217 5.76182 52.1534 6.00868 52.3848C6.05732 52.4303 6.08585 52.4631 6.1015 52.4833C6.09439 52.8454 5.90271 53.1782 4.82401 54.2568L4.69268 54.3874C3.81309 55.2599 2.21988 56.84 2.21988 59.2545C2.21988 61.9021 4.16048 63.7086 5.72794 64.6911C7.35288 65.7096 9.38212 66.3713 10.9541 66.3713H13.2185V61.8425H10.9541C10.4233 61.8425 9.21761 61.5336 8.13335 60.8539C6.99161 60.1383 6.74869 59.5185 6.74869 59.2545C6.74869 58.8836 6.92608 58.5596 8.02638 57.4593L8.15771 57.3286C9.03732 56.4562 10.6305 54.8761 10.6305 52.4613C10.6305 50.9439 9.9129 49.8371 9.10611 49.0808C8.41653 48.4343 7.55946 47.9531 6.97309 47.6241L6.88838 47.5765C6.20025 47.1893 5.81632 46.9597 5.56866 46.7346C5.61377 46.6968 5.66936 46.6529 5.73754 46.6033C6.24117 46.236 6.99861 45.8671 7.97977 45.4378C8.1434 45.3663 8.31679 45.2918 8.49613 45.2145C9.26958 44.8814 10.1545 44.5006 10.851 44.1088C11.2887 43.8625 11.8089 43.5291 12.2425 43.0837C12.6804 42.6343 13.2185 41.8705 13.2185 40.8159C13.2185 39.5918 12.6204 38.617 12.159 38.0015C11.697 37.3856 11.1137 36.8025 10.6642 36.3533L10.6142 36.3034C10.0995 35.7885 9.73872 35.4215 9.49022 35.0902C9.42428 35.0023 9.38158 34.9364 9.35465 34.8909C9.35775 34.8782 9.36142 34.8644 9.3657 34.8495C9.39437 34.7492 9.44514 34.6167 9.5272 34.4584C9.69368 34.1375 9.9542 33.7768 10.2908 33.4403C11.0145 32.7166 11.7663 32.4053 12.2479 32.4053H14.5124V27.8765H12.2479Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M68.8096 30.4805C67.9364 29.3166 66.379 27.8765 64.3292 27.8765H62.0648V32.4053H64.2998C64.3229 32.4125 64.3885 32.437 64.4986 32.5101C64.6951 32.6412 64.9406 32.8699 65.1865 33.1978C65.711 33.8971 65.9381 34.6291 65.9465 34.9738C65.9412 34.9951 65.9129 35.1067 65.7825 35.3388C65.5962 35.6701 65.3285 36.0331 64.9438 36.546L64.9076 36.5944C64.5686 37.0459 64.1279 37.6333 63.781 38.2501C63.4212 38.8896 63.0353 39.7741 63.0353 40.8159C63.0353 42.4816 64.2595 43.5031 64.8509 43.9467C65.4098 44.3658 66.1242 44.7757 66.7044 45.1086C66.7288 45.1224 66.7528 45.1362 66.7766 45.15C66.8798 45.2091 66.9783 45.2657 67.0701 45.3194C67.7983 45.744 68.3071 46.0791 68.6341 46.397C68.7822 46.541 68.839 46.6284 68.8583 46.6672C68.8603 46.8365 68.8519 46.9667 67.823 47.7384L67.7045 47.8268C66.7974 48.5009 64.9762 49.8548 64.9762 52.4613C64.9762 54.6802 66.1066 56.1824 66.8097 57.1167L66.8848 57.2166C67.6463 58.2319 67.8875 58.6429 67.8875 59.2545C67.8875 59.7443 67.5741 60.3763 66.7881 61.011C66.4222 61.3065 66.0282 61.537 65.6897 61.6865C65.4546 61.7902 65.314 61.8255 65.2674 61.8373L65.2545 61.8407L65.2499 61.8425H63.0353V66.3713H65.2997C66.0785 66.3713 66.8789 66.1118 67.5177 65.8299C68.2104 65.5242 68.9484 65.0876 69.6338 64.5342C70.9508 63.4704 72.4163 61.6763 72.4163 59.2545C72.4163 57.0359 71.2859 55.5337 70.583 54.5994L70.5079 54.4993C69.7464 53.4841 69.505 53.0729 69.505 52.4613L69.5047 52.4378C69.5027 52.2659 69.5011 52.1407 70.5403 51.3615L70.6587 51.2732C71.5656 50.5991 73.3868 49.2452 73.3868 46.6386C73.3868 45.0726 72.5807 43.9177 71.7911 43.1501C71.0264 42.4065 70.0797 41.8318 69.3521 41.4074C69.1621 41.2967 68.9876 41.1961 68.8263 41.1033C68.3732 40.8422 68.0259 40.6423 67.7412 40.4473C67.9271 40.1221 68.1912 39.7641 68.5668 39.2632L68.6033 39.2148C68.942 38.763 69.3829 38.1756 69.7298 37.559C70.0894 36.9196 70.4755 36.0351 70.4755 34.9933C70.4755 33.388 69.7305 31.7087 68.8096 30.4805ZM67.3447 40.1296C67.3447 40.1296 67.3517 40.1405 67.3739 40.1624C67.3574 40.1407 67.3447 40.1296 67.3447 40.1296ZM68.8669 46.6907L68.866 46.6853L68.8644 46.6805L68.861 46.6726C68.8632 46.6846 68.8669 46.6907 68.8669 46.6907Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M68.858 6.36468C68.858 3.2382 71.3925 0.703674 74.519 0.703674C77.6455 0.703674 80.18 3.2382 80.18 6.36468V16.6688C81.5808 18.0984 82.4444 20.0559 82.4444 22.2155C82.4444 26.5926 78.8961 30.1409 74.519 30.1409C70.1419 30.1409 66.5936 26.5926 66.5936 22.2155C66.5936 20.0559 67.4572 18.0984 68.858 16.6688V6.36468ZM73.3868 18.518L72.0927 19.8386C71.4879 20.4558 71.1224 21.2885 71.1224 22.2155C71.1224 24.0913 72.6432 25.6121 74.519 25.6121C76.3948 25.6121 77.9156 24.0913 77.9156 22.2155C77.9156 21.2885 77.5501 20.4558 76.9453 19.8386L75.6512 18.518V14.2901H73.3868V18.518ZM74.519 5.23248C75.1442 5.23248 75.6512 5.73939 75.6512 6.36468V9.76128H73.3868V6.36468C73.3868 5.73939 73.8938 5.23248 74.519 5.23248Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("E6E9F4CA-33EC-4DF4-A15F-BB69C61A4691"),
                         Title = "Lả nhiệt",
                         Image = @"<svg width=""87"" height=""87"" viewBox=""0 0 87 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M68.9037 71.5873C62.1559 77.7298 53.1868 81.4742 43.3431 81.4742C35.8276 81.4742 28.822 79.2916 22.9255 75.5255C22.2078 76.9706 21.244 78.2644 20.0909 79.3481C26.7827 83.6963 34.7681 86.2222 43.3431 86.2222C55.3561 86.2222 66.2112 81.2651 73.9748 73.2847C72.1444 73.0813 70.4276 72.488 68.9037 71.5873Z"" fill=""#F23929""/>
<path d=""M85.6342 49.6468C85.9243 47.6368 86.0743 45.5814 86.0743 43.4909C86.0743 19.8909 66.9427 0.759277 43.3427 0.759277C19.7428 0.759277 0.611115 19.8909 0.611115 43.4909C0.611115 47.9936 1.30755 52.3337 2.59859 56.4093C3.74745 54.5548 4.9973 52.8572 6.18179 51.3912C5.64266 48.8428 5.35907 46.1998 5.35907 43.4909C5.35907 22.513 22.3648 5.50723 43.3427 5.50723C64.1345 5.50723 81.0244 22.2127 81.3223 42.9337C82.8243 44.8868 84.3689 47.1727 85.6342 49.6468Z"" fill=""#F23929""/>
<path d=""M18.9921 34.8263C18.7093 36.5775 19.8975 38.2571 21.5191 39.2955C23.2135 40.3809 25.6292 40.9741 28.4742 40.5542C31.4322 40.1176 33.5343 38.4765 34.7735 36.6006C35.9707 34.788 36.4636 32.5817 35.9135 30.9465C35.7844 30.5623 35.4682 30.2706 35.0748 30.1728C34.6814 30.0752 34.2653 30.1849 33.9714 30.4641C29.708 34.511 24.8935 35.5052 20.5772 33.9025C20.2441 33.7789 19.8733 33.8109 19.5663 33.9899C19.2594 34.1687 19.0488 34.4756 18.9921 34.8263Z"" fill=""#F23929""/>
<path d=""M66.6519 34.8263C66.9345 36.5775 65.7465 38.2571 64.1248 39.2955C62.4303 40.3809 60.0148 40.9741 57.1696 40.5542C54.2118 40.1176 52.1097 38.4765 50.8705 36.6006C49.673 34.788 49.1802 32.5817 49.7302 30.9465C49.8596 30.5623 50.1758 30.2706 50.5692 30.1728C50.9626 30.0752 51.3787 30.1849 51.6726 30.4641C55.9361 34.511 60.7502 35.5052 65.0668 33.9025C65.3999 33.7789 65.7707 33.8109 66.0777 33.9899C66.3846 34.1687 66.5952 34.4756 66.6519 34.8263Z"" fill=""#F23929""/>
<path d=""M83.7003 59.4614C83.7003 63.7523 79.9803 67.2307 75.3914 67.2307C70.8025 67.2307 67.0825 63.7523 67.0825 59.4614C67.0825 52.663 75.3914 45.8649 75.3914 45.8649C75.3914 45.8649 83.7003 52.663 83.7003 59.4614Z"" fill=""#F23929""/>
<path d=""M11.294 76.7265C15.8829 76.7265 19.603 73.2482 19.603 68.9572C19.603 62.1588 11.294 55.3607 11.294 55.3607C11.294 55.3607 2.98511 62.1588 2.98511 68.9572C2.98511 73.2482 6.70513 76.7265 11.294 76.7265Z"" fill=""#F23929""/>
<path d=""M60.9255 64.8567C57.6589 56.4013 51.0115 50.6128 43.3426 50.6128C35.6735 50.6128 29.0261 56.4013 25.7598 64.8567C24.8401 67.2373 26.7564 69.6046 29.3084 69.6046H57.3766C59.9287 69.6046 61.8452 67.2373 60.9255 64.8567Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                         Title = "Sốt cao",
                         Image = @"<svg width=""61"" height=""87"" viewBox=""0 0 61 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M43.4907 0.759277C37.5908 0.759277 32.8079 5.88379 32.8079 12.2052V55.7859C28.9003 58.9185 26.3981 63.7318 26.3981 69.1296C26.3981 78.5697 34.0507 86.2222 43.4907 86.2222C52.9308 86.2222 60.5833 78.5697 60.5833 69.1296C60.5833 63.7318 58.0812 58.9185 54.1736 55.7859V12.2052C54.1736 5.88379 49.3907 0.759277 43.4907 0.759277ZM49.9005 39.3479C46.7873 39.4001 43.8706 38.6435 41.3166 37.981C39.7569 37.5765 38.3326 37.2069 37.081 37.078V12.2052C37.081 8.41236 39.9507 5.33766 43.4907 5.33766C47.0308 5.33766 49.9005 8.41236 49.9005 12.2052V13.5273H45.6273C44.4473 13.5273 43.4907 14.484 43.4907 15.664C43.4907 16.8438 44.4473 17.8006 45.6273 17.8006H49.9005V22.0737H45.6273C44.4473 22.0737 43.4907 23.0303 43.4907 24.2103C43.4907 25.3901 44.4473 26.3469 45.6273 26.3469H49.9005V30.62H45.6273C44.4473 30.62 43.4907 31.5766 43.4907 32.7566C43.4907 33.9364 44.4473 34.8932 45.6273 34.8932H49.9005V39.3479Z"" fill=""#F23929""/>
<path d=""M13.1775 14.7032C12.4062 13.2038 10.4781 13.2038 9.70684 14.7032L1.03064 31.571C0.259508 33.0702 1.22357 34.9444 2.76597 34.9444H9.30559V54.1736H13.5787V34.9444H20.1184C21.6608 34.9444 22.6248 33.0702 21.8537 31.571L13.1775 14.7032Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                         Title = "Chảy máu cam",
                         Image = @"<svg width=""38"" height=""70"" viewBox=""0 0 38 70"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M28.8766 0.975824C29.6116 1.29994 29.9448 2.15863 29.6207 2.89373L28.2896 2.30687C29.6207 2.89373 29.6208 2.8934 29.6207 2.89373L29.6199 2.89542L29.6127 2.91203L29.591 2.96075C29.5721 3.00318 29.5441 3.06536 29.5076 3.14618C29.4346 3.30784 29.327 3.54419 29.1869 3.84661C28.9064 4.45135 28.4957 5.32074 27.9718 6.38574C26.9241 8.51446 25.4201 11.431 23.5946 14.5808C19.9824 20.8136 14.9761 28.2026 9.63755 32.0505L9.63508 32.0524C4.02467 36.0786 2.94078 40.4926 3.84749 43.6741C4.78096 46.9501 7.91958 49.3986 11.7698 49.3986H12.4563C12.9016 47.8472 14.0623 46.3474 16.0374 45.4264C18.2759 44.3825 21.4485 44.1245 25.7092 45.1134C26.4918 45.2949 26.979 46.0767 26.7973 46.8591C26.6157 47.6418 25.834 48.1289 25.0514 47.9474C21.1659 47.0455 18.7137 47.3885 17.2671 48.0632C16.4769 48.4315 15.9561 48.9101 15.6294 49.3986H16.4668C20.1844 49.3986 23.1982 52.4124 23.1982 56.1301H20.2889C20.2889 54.0192 18.5777 52.3079 16.4668 52.3079H11.7698C6.6716 52.3079 2.35309 49.0464 1.04941 44.4714C-0.281044 39.8026 1.61761 34.2257 7.93732 29.6897C12.7257 26.2379 17.4704 19.3454 21.0775 13.1219C22.8618 10.0432 24.3346 7.18744 25.3613 5.1011C25.8744 4.05853 26.2753 3.20965 26.5472 2.62302C26.6832 2.32974 26.7869 2.10211 26.8562 1.94873C26.8908 1.87204 26.9168 1.81391 26.934 1.77543L26.9531 1.73258L26.9584 1.72026C27.2827 0.985149 28.1414 0.651707 28.8766 0.975824Z"" fill=""#F23929""/>
<path d=""M31.9684 51.5459C34.02 50.2673 35.9074 47.5203 36.6624 44.4793C37.4347 41.3686 37.0784 37.6957 34.2478 34.7555L32.1519 36.7733C34.1231 38.8207 34.4337 41.382 33.8389 43.7783C33.2266 46.2443 31.7127 48.277 30.4297 49.0767L31.9684 51.5459Z"" fill=""#F23929""/>
<path d=""M27.4167 63.2271C27.4167 66.5381 24.6813 69.2222 21.307 69.2222C17.9327 69.2222 15.1973 66.5381 15.1973 63.2271C15.1973 57.9814 21.307 51.766 21.307 51.766C21.307 51.766 27.4167 57.9814 27.4167 63.2271Z"" fill=""#F23929""/>
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M21.307 68.3494C24.2149 68.3494 26.5439 66.0406 26.5439 63.2271C26.5439 60.8894 25.1571 58.2148 23.6439 56.0257C22.9021 54.9527 22.1588 54.0368 21.6005 53.3889C21.4955 53.2671 21.3973 53.155 21.307 53.0533C21.2167 53.155 21.1185 53.2671 21.0135 53.3889C20.4552 54.0368 19.7119 54.9527 18.9701 56.0257C17.4569 58.2148 16.0702 60.8894 16.0702 63.2271C16.0702 66.0406 18.3991 68.3494 21.307 68.3494ZM20.7134 52.4075C19.1784 54.1264 15.1973 58.9927 15.1973 63.2271C15.1973 66.5381 17.9327 69.2222 21.307 69.2222C24.6813 69.2222 27.4167 66.5381 27.4167 63.2271C27.4167 58.9927 23.4356 54.1264 21.9006 52.4075C21.5341 51.997 21.307 51.766 21.307 51.766C21.307 51.766 21.0799 51.997 20.7134 52.4075Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                         Title = "Ngất",
                         Image = @"<svg width=""87"" height=""61"" viewBox=""0 0 87 61"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M26.7701 3.32428C23.6249 0.17736 18.5236 0.175609 15.376 3.32043L13.8716 4.82351C11.0103 4.01033 7.80901 4.73805 5.55595 7.00624C2.23136 10.3534 2.23136 15.7856 5.55595 19.1328L7.33566 20.9245V43.6944H0.925934V47.9676H5.307C3.9219 49.3249 3.06251 51.2167 3.06251 53.309C3.06251 57.439 6.41052 60.787 10.5405 60.787C14.6705 60.787 18.0185 57.439 18.0185 53.309C18.0185 51.2167 17.1592 49.3249 15.7741 47.9676H71.5408C70.1556 49.3249 69.2963 51.2167 69.2963 53.309C69.2963 57.439 72.6443 60.787 76.7743 60.787C80.9043 60.787 84.2523 57.439 84.2523 53.309C84.2523 51.2167 83.393 49.3249 82.0079 47.9676H86.3889V43.6944H77.8426V37.0439C81.5214 36.1408 84.2523 32.7964 84.2523 28.8089C84.2523 24.1283 80.4894 20.334 75.8475 20.334H31.073C30.8989 20.334 30.7316 20.2641 30.6083 20.14L29.8254 19.352L30.6126 18.5655C33.7604 15.4205 33.7621 10.3196 30.6164 7.17246L26.7701 3.32428ZM26.8142 16.3202L27.5923 15.5427C29.0704 14.0659 29.0712 11.671 27.5942 10.1934L23.748 6.34518C22.2707 4.8671 19.8746 4.86624 18.3963 6.34326L17.6474 7.09148L26.8142 16.3202ZM73.5695 43.6944H11.6088V25.2265L22.8797 36.5736C23.3315 37.0285 23.9439 37.2841 24.5825 37.2841H73.5695V43.6944Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("76B241EE-7275-4449-AD4D-6813AC2C112A"),
                         Id = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                         Title = "Ngộ độc",
                         Image = @"<svg width=""87"" height=""87"" viewBox=""0 0 87 87"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M46.9035 22.1249C52.8036 22.1249 57.5864 17.3421 57.5864 11.442C57.5864 5.54216 52.8036 0.759277 46.9035 0.759277C41.0035 0.759277 36.2207 5.54216 36.2207 11.442C36.2207 17.3421 41.0035 22.1249 46.9035 22.1249ZM57.8646 29.3733C57.8646 30.7545 56.7396 31.8741 55.3516 31.8741C53.9637 31.8741 52.8387 30.7545 52.8387 29.3733C52.8387 27.9922 53.9637 26.8726 55.3516 26.8726C56.7396 26.8726 57.8646 27.9922 57.8646 29.3733ZM86.0743 80.2869C86.0743 83.5646 78.1027 86.2218 68.2695 86.2218C58.436 86.2218 50.4647 83.5646 50.4647 80.2869C50.4647 77.0091 58.436 74.352 68.2695 74.352C68.7153 74.352 69.1576 74.3574 69.5954 74.3681C69.5049 74.046 69.4565 73.7062 69.4565 73.3551C69.4565 71.2834 71.1441 69.604 73.2259 69.604C75.3076 69.604 76.9955 71.2834 76.9955 73.3551C76.9955 73.9607 76.8512 74.5329 76.595 75.0395C82.2332 76.0353 86.0743 78.0117 86.0743 80.2869ZM61.356 46.2447C63.4378 46.2447 65.1257 44.5653 65.1257 42.4935C65.1257 40.4218 63.4378 38.7424 61.356 38.7424C59.2743 38.7424 57.5866 40.4218 57.5866 42.4935C57.5866 44.5653 59.2743 46.2447 61.356 46.2447ZM74.4824 55.487C74.4824 56.8682 73.3574 57.9877 71.9693 57.9877C70.5815 57.9877 69.4565 56.8682 69.4565 55.487C69.4565 54.1058 70.5815 52.9862 71.9693 52.9862C73.3574 52.9862 74.4824 54.1058 74.4824 55.487ZM60.0995 65.1096C61.4875 65.1096 62.6126 63.9901 62.6126 62.6089C62.6126 61.2277 61.4875 60.1082 60.0995 60.1082C58.7117 60.1082 57.5866 61.2277 57.5866 62.6089C57.5866 63.9901 58.7117 65.1096 60.0995 65.1096ZM15.6813 46.7683C17.2444 48.5358 18.839 50.1679 20.1086 51.4171C20.8326 52.1295 21.4418 52.7083 21.8665 53.1057C22.0785 53.3044 22.2442 53.4572 22.3543 53.5584L22.4768 53.6702L22.5048 53.6956L22.5096 53.6999C23.4343 54.5336 23.9952 55.6983 24.07 56.9413L25.5295 81.189C25.6872 83.8063 23.693 86.0561 21.0755 86.2135C18.4582 86.3711 16.2084 84.377 16.051 81.7595L14.7052 59.4033C14.3389 59.0539 13.9149 58.6446 13.4486 58.1859C11.8804 56.6429 9.79474 54.5025 7.78814 52.1637C5.81889 49.8685 3.7547 47.1864 2.37531 44.575C1.68738 43.2729 1.05267 41.7726 0.76877 40.1972C0.483633 38.6152 0.488358 36.5558 1.61621 34.6022C8.01965 23.5111 14.4129 18.2247 20.2 16.068C23.0841 14.993 25.6261 14.7715 27.6495 14.8627C29.236 14.9344 31.5349 15.3738 31.125 15.3216C33.4764 15.6207 34.6527 17.3093 35.0845 18.1497C35.5218 19.0005 35.6823 19.8402 35.757 20.348C35.9163 21.4308 35.9038 22.6621 35.8484 23.761C35.7335 26.0476 35.3613 28.9318 34.9459 31.649C34.525 34.4024 34.0364 37.1322 33.6551 39.1638C33.5868 39.528 33.5217 39.8703 33.4612 40.187L42.2406 49.7845C44.0104 51.7193 43.8767 54.7226 41.942 56.4924C40.0072 58.2624 37.0039 58.1285 35.2341 56.1937L24.8363 44.8274C23.8096 43.705 23.3827 42.1586 23.6885 40.6684L23.6994 40.615L23.7339 40.4448C23.7642 40.2941 23.8089 40.0711 23.8654 39.7858C23.9781 39.2151 24.1374 38.3965 24.3221 37.4125C24.4584 36.6866 24.6077 35.8737 24.762 35.0063C21.2412 38.0761 18.9586 41.3068 16.5258 45.3608L15.6813 46.7683Z"" fill=""#F23929""/>
</svg>
"
                     },
            #endregion
                     //Kỹ năng Id = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
            #region Kỹ năng
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
                         Id = Guid.Parse("280F5A0E-0379-4B8E-A09D-AACDA21CDDAF"),
                         Title = "Thắt nút dây",
                         Image = @"<svg width=""91"" height=""85"" viewBox=""0 0 91 85"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M45.2226 37.778C51.296 35.2608 56.8105 31.5652 61.4475 26.9047C70.5339 17.8183 76.4129 3.38892 76.4129 3.38892M61.4933 57.6767C59.9658 63.804 58.8523 68.0269 56.2113 70.9468C50.1167 77.6799 36.8661 81.4562 28.4181 68.7024C22.9662 60.4702 25.8534 49.5686 33.6565 43.6874C34.665 42.8526 35.7609 42.1294 36.925 41.5302M87.9072 18.3543C81.8306 22.8741 76.2254 27.9952 71.1768 33.6401C67.1674 38.0199 65.4961 42.4977 63.7856 48.8495M21.9051 64.8085C15.3786 68.0599 9.04204 71.6793 2.92593 75.6491"" stroke=""#F23929"" stroke-width=""5"" stroke-linecap=""round"" stroke-linejoin=""round""/>
<path d=""M78.7552 31.217C82.0085 38.0743 81.1478 44.3128 77.0556 47.5378C68.0563 54.6217 57.085 53.6063 42.636 57.0513C38.2735 58.1171 33.9989 59.515 29.8496 61.2328M70.9108 20.5944C72.4756 21.6663 73.8413 23.0032 74.9463 24.5449"" stroke=""#F23929"" stroke-width=""5"" stroke-linecap=""round"" stroke-linejoin=""round""/>
<path d=""M44.6431 52.2424C39.7447 42.0011 38.7141 31.3392 48.086 21.8823C50.0854 19.6796 52.6617 18.0808 55.5231 17.2671C58.3845 16.4533 61.4166 16.4571 64.276 17.2781M68.7168 82.2778C65.6291 79.3994 55.7735 71.4024 48.6438 60.1544"" stroke=""#F23929"" stroke-width=""5"" stroke-linecap=""round"" stroke-linejoin=""round""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
                         Id = Guid.Parse("39047891-AE02-4927-849B-A950F85F4480"),
                         Title = "Tín hiệu cầu cứu",
                         Image = @"<svg width=""67"" height=""63"" viewBox=""0 0 67 63"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M55.2593 14.6212H51.6327V11.0053C51.6308 8.91211 51.0215 6.86414 49.8784 5.10845C48.7352 3.35276 47.107 1.96433 45.1902 1.11065C43.2733 0.256963 41.1497 -0.0255204 39.0754 0.29727C37.0011 0.620061 35.0648 1.53434 33.5 2.92982C32.1183 1.69729 30.4436 0.837255 28.6348 0.431359C26.8261 0.025462 24.9433 0.0871649 23.1652 0.610611C21.3871 1.13406 19.7726 2.10188 18.475 3.42223C17.1775 4.74257 16.2398 6.37163 15.7511 8.1548C14.101 7.50242 12.3159 7.26249 10.5515 7.45595C8.78707 7.64941 7.09692 8.27039 5.62847 9.26471C4.16002 10.259 2.95787 11.5965 2.1269 13.1604C1.29593 14.7244 0.861362 16.4673 0.861115 18.2371V30.2902C0.861115 38.9211 4.29985 47.1986 10.4208 53.3016C16.5418 59.4047 24.8436 62.8333 33.5 62.8333C42.1564 62.8333 50.4582 59.4047 56.5792 53.3016C62.7002 47.1986 66.1389 38.9211 66.1389 30.2902V25.469C66.1389 22.592 64.9927 19.8328 62.9523 17.7985C60.912 15.7641 58.1447 14.6212 55.2593 14.6212ZM37.1265 11.0053C37.1265 10.0463 37.5086 9.12663 38.1887 8.44851C38.8688 7.7704 39.7913 7.38944 40.7531 7.38944C41.7149 7.38944 42.6373 7.7704 43.3174 8.44851C43.9976 9.12663 44.3796 10.0463 44.3796 11.0053V14.6212H37.1265V11.0053ZM22.6204 11.0053C22.6204 10.0463 23.0025 9.12663 23.6826 8.44851C24.3627 7.7704 25.2851 7.38944 26.2469 7.38944C27.2087 7.38944 28.1312 7.7704 28.8113 8.44851C29.4914 9.12663 29.8735 10.0463 29.8735 11.0053V23.0584C29.8735 24.0174 29.4914 24.9371 28.8113 25.6152C28.1312 26.2933 27.2087 26.6743 26.2469 26.6743C25.2851 26.6743 24.3627 26.2933 23.6826 25.6152C23.0025 24.9371 22.6204 24.0174 22.6204 23.0584V11.0053ZM8.1142 18.2371C8.1142 17.2782 8.49628 16.3584 9.17639 15.6803C9.8565 15.0022 10.7789 14.6212 11.7407 14.6212C12.7026 14.6212 13.625 15.0022 14.3051 15.6803C14.9852 16.3584 15.3673 17.2782 15.3673 18.2371V23.0584C15.3673 24.0174 14.9852 24.9371 14.3051 25.6152C13.625 26.2933 12.7026 26.6743 11.7407 26.6743C10.7789 26.6743 9.8565 26.2933 9.17639 25.6152C8.49628 24.9371 8.1142 24.0174 8.1142 23.0584V18.2371ZM58.8858 30.2902C58.8893 36.7403 56.4229 42.9484 51.9904 47.6465C47.5579 52.3447 41.4938 55.1783 35.0365 55.5687C28.5792 55.9591 22.2161 53.8768 17.2468 49.7471C12.2774 45.6174 9.07675 39.7519 8.29855 33.3486C10.1186 33.9546 12.0671 34.0689 13.9458 33.6798C15.8246 33.2908 17.5663 32.4123 18.9938 31.1339C20.7733 32.729 23.0319 33.6926 25.4179 33.8747C27.8038 34.0567 30.1832 33.4469 32.1854 32.1403C32.7428 32.856 33.3875 33.4998 34.1044 34.0567C31.3807 36.956 29.8677 40.7813 29.8735 44.7538C29.8735 45.7128 30.2555 46.6325 30.9356 47.3106C31.6158 47.9887 32.5382 48.3697 33.5 48.3697C34.4618 48.3697 35.3842 47.9887 36.0644 47.3106C36.7445 46.6325 37.1265 45.7128 37.1265 44.7538C37.1265 42.5161 38.0181 40.3701 39.605 38.7878C41.1919 37.2056 43.3442 36.3167 45.5885 36.3167C46.5503 36.3167 47.4727 35.9357 48.1528 35.2576C48.8329 34.5795 49.215 33.6598 49.215 32.7008C49.215 31.7418 48.8329 30.822 48.1528 30.1439C47.4727 29.4658 46.5503 29.0849 45.5885 29.0849H40.7531C39.7913 29.0849 38.8688 28.7039 38.1887 28.0258C37.5086 27.3477 37.1265 26.428 37.1265 25.469V21.8531H55.2593C56.2211 21.8531 57.1435 22.234 57.8236 22.9121C58.5037 23.5902 58.8858 24.51 58.8858 25.469V30.2902Z"" fill=""#F23929""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
                         Id = Guid.Parse("3BA5C72A-2843-4DD8-A958-F008A6BFF38B"),
                         Title = "Tạo lửa",
                         Image = @"<svg width=""73"" height=""90"" viewBox=""0 0 73 90"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M64.0799 38.5381C64.0799 53.7701 51.7319 66.118 36.5 66.118C21.2681 66.118 8.92014 53.7701 8.92014 38.5381C8.92014 23.3062 19.5278 17.3229 23.7708 2.47217C40.7431 9.89728 40.7431 32.1736 40.7431 32.1736C40.7431 32.1736 44.9861 19.4444 57.7153 16.2621C58.776 27.9305 64.0799 32.034 64.0799 38.5381Z"" stroke=""#F23929"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
<path d=""M2.55556 70.3611L70.4444 87.3333"" stroke=""#F23929"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
<path d=""M2.55556 87.3333L70.4444 70.3611"" stroke=""#F23929"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
</svg>
"
                     },
                     new Emergency
                     {
                         EmergencyCategoryId = Guid.Parse("A403FF66-6735-4516-AE28-23DE65C52CEA"),
                         Id = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                         Title = "Xác định phương hướng",
                         Image = @"<svg width=""69"" height=""69"" viewBox=""0 0 69 69"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
<path d=""M34.5 4.13269C28.5323 4.13269 22.6987 5.9023 17.7368 9.21773C12.7749 12.5332 8.9076 17.2455 6.62389 22.7589C4.34018 28.2722 3.74265 34.339 4.90688 40.192C6.0711 46.0449 8.94479 51.4212 13.1645 55.6409C17.3843 59.8607 22.7606 62.7344 28.6135 63.8986C34.4665 65.0628 40.5332 64.4653 46.0466 62.1816C51.56 59.8979 56.2723 56.0306 59.5878 51.0687C62.9032 46.1068 64.6728 40.2732 64.6728 34.3055C64.6728 26.3032 61.4939 18.6286 55.8354 12.9701C50.1769 7.31161 42.5023 4.13269 34.5 4.13269ZM12.7567 36.1913H8.19301C8.19301 35.569 8.09872 34.9467 8.09872 34.3055C8.09872 33.6644 8.09872 33.042 8.19301 32.4197H12.7567V36.1913ZM32.6142 7.99859C33.2365 7.99859 33.8588 7.9043 34.5 7.9043C35.1411 7.9043 35.7634 7.9043 36.3858 7.99859V12.5622H32.6142V7.99859ZM36.3858 60.6125C35.7634 60.6125 35.1411 60.7068 34.5 60.7068C33.8588 60.7068 33.2365 60.7068 32.6142 60.6125V56.0488H36.3858V60.6125ZM51.4722 50.0897C51.3172 50.2741 51.1065 50.4031 50.8719 50.4575C50.6373 50.512 50.3913 50.4888 50.171 50.3914L30.2569 38.7937L18.6592 18.8797C18.1878 17.9933 19.3947 16.8053 20.281 17.2956L39.8368 29.2327L51.7739 48.7885C51.8712 49.0088 51.8944 49.2548 51.84 49.4894C51.7856 49.724 51.6565 49.9347 51.4722 50.0897ZM56.2433 36.1913V32.4197H60.8069C60.8069 33.042 60.9012 33.6644 60.9012 34.3055C60.9012 34.9467 60.9012 35.569 60.8069 36.1913H56.2433Z"" fill=""#F23929""/>
<path d=""M32.1804 36.8514L46.4748 45.1866L37.8944 31.1562L32.1804 36.8514Z"" fill=""#F23929""/>
</svg>
"
                     }
                );
            #endregion
            #endregion
            #region Emergency Details
            // Hỏa hoạn                        Id = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
            builder.Entity<EmergencyDetail>()
                .HasData(
            #region Hỏa hoạn

                new EmergencyDetail
                {
                    Id = Guid.Parse("5074C5AA-B04B-41DF-89A2-3177705C1A57"),
                    EmergencyId = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                    Step = 1,
                    TopContent = @"1. Thoát ra khỏi đám cháy
2. Tránh nơi có nhiều khói",
                    MainPictureUrl = "hoahoan_main_step_1",
                    ActionContent = "GỌI 114",
                    ContentLeft = "Chuông báo",
                    ContentLeftUrl = "hoahoan_left_step_1",
                    ContentRight = "Hô hoán",
                    ContentRightUrl = "hoahoan_right_step_1"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("64D9B4F9-B12A-4C66-9B12-E1F79E4B7878"),
                    EmergencyId = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                    Step = 2,
                    TopContent = @"1. Thoát ra khỏi đám cháy
2. Tránh nơi có nhiều khói",
                    MainPictureUrl = "hoahoan_main_step_2",
                    ActionContent = "Tìm lối thoát hiểm gần nhất, kiểm tra xem có khói không?",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("E73411BC-D4D7-4801-BDD9-D7DF984B01AA"),
                    EmergencyId = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                    Step = 3,
                    TopContent = @"1. Thoát ra khỏi đám cháy
2. Tránh nơi có nhiều khói",
                    MainPictureUrl = "hoahoan_main_step_3",
                    ContentBottom = "Quay trở lại phòng trú ẩn, dùng băng dán hoặc vải để dán kín các khe hở tại cửa",
                    ActionContent = "Dán kín cửa phòng"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("ABAC6286-767D-4BAA-BC63-2FCC3E70A48E"),
                    EmergencyId = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                    Step = 4,
                    TopContent = @"1. Thoát ra khỏi đám cháy
2. Tránh nơi có nhiều khói",
                    MainPictureUrl = "hoahoan_main_step_4",
                    ActionContent = "Hô hoán và chờ đợi",
                    ContentBottom = "Bình tĩnh ra tín hiệu và chờ đợi người đến cứu",
                    IsSafe = true
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("0E4EBAAC-A0E4-4AA8-8D6C-6EEFA8DC4D63"),
                    EmergencyId = Guid.Parse("48AE3BFF-69B9-49F6-AD3E-E7408E44C081"),
                    Step = 5,
                    TopContent = @"1. Thoát ra khỏi đám cháy
2. Tránh nơi có nhiều khói",
                    MainPictureUrl = @"hoahoan_main_step_5",
                    ActionContent = "Bạn đã an toàn",
                    ContentBottom = "Xin chúc mừng",
                    IsSafe = true
                },
            #endregion

            #region Tạo lửa Id = Guid.Parse("3BA5C72A-2843-4DD8-A958-F008A6BFF38B"),
                new EmergencyDetail
                {
                    Id = GuidParse("{632BA757-0DC2-4A89-8462-285041471DB2}"),
                    EmergencyId = Guid.Parse("3BA5C72A-2843-4DD8-A958-F008A6BFF38B"),
                    Step = 1,
                    TopContent = @"Sinh tồn trong môi trường khắc nghiệt",
                    MainPictureUrl = "taolua_main_step_1",
                    ActionContent = "Dùng dao hoặc đá sắc để bào mỏng một đầu của que cọ.",
                    IsSafe = true
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{616FCFD4-AAD3-4881-8FC2-CFBBFA2077DD}"),
                    EmergencyId = Guid.Parse("3BA5C72A-2843-4DD8-A958-F008A6BFF38B"),
                    Step = 2,
                    TopContent = @"Sinh tồn trong môi trường khắc nghiệt",
                    MainPictureUrl = "taolua_main_step_2",
                    ActionContent = "Dùng tay di chuyển que cọ qua lại tạo ra lực ma sát",
                    IsSafe = true
                },
            #endregion

            #region Con trùng cắn Id = Guid.Parse("C813800B-BA50-4270-B3A6-9313E7884646"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("4787DAB5-0205-412A-A0B3-D15F716A25F1"),
                    EmergencyId = Guid.Parse("C813800B-BA50-4270-B3A6-9313E7884646"),
                    Step = 1,
                    TopContent = @"Hạn chế tối đa nguy cơ nhiễm trùng",
                    MainPictureUrl = "contrungcan_main_step_1",
                    ActionContent = "Rửa vết thương bằng nước sạch",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("45DC3263-0892-40FA-BC5B-2A9CD86BE147"),
                    EmergencyId = Guid.Parse("C813800B-BA50-4270-B3A6-9313E7884646"),
                    Step = 2,
                    TopContent = @"Hạn chế tối đa nguy cơ nhiễm trùng",
                    MainPictureUrl = "contrungcan_main_step_2",
                    ActionContent = "Đắp 1 cái khăn lên vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("55C613DB-7C7D-4C61-AABA-BDFB6EE2222B"),
                    EmergencyId = Guid.Parse("C813800B-BA50-4270-B3A6-9313E7884646"),
                    Step = 3,
                    TopContent = @"Hạn chế tối đa nguy cơ nhiễm trùng",
                    MainPictureUrl = "contrungcan_main_step_3",
                    ActionContent = "Dùng 1 túi có đá lạnh và nước đặt lên tấm khăn trong 20 phút",
                    IsSafe = true
                },
            #endregion

            #region Xác định phương hướng Id = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                new EmergencyDetail
                {
                    Id = GuidParse("{79509A95-2CE1-496E-82F6-98B31940C359}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 1,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_1",
                    ActionContent = "Cắm cọc xuống mặt phẳng sao cho cọc đứng thẳng.",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{A82EAF8A-5CB2-4815-9394-59110A2A3699}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 2,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_2",
                    ActionContent = "Đánh dấu vị trí của đầu bóng cọc.",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{89D12998-FD7A-4858-8F65-6CA330469D80}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 3,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_3",
                    ActionContent = "Đợi 15-20 phút để bóng cọc di chuyển.",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{FBF0061B-5F88-45F1-8546-CA2E9D5ED35D}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 4,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_4",
                    ActionContent = "Đánh dấu vị trí mới của đầu bóng cọc.",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{B02698B9-8560-4C1B-967B-8C4CF7C68C03}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 5,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_5",
                    ActionContent = "Nối hai điểm đánh dấu bằng một đường thẳng.",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{DE66382B-5819-4D2C-B0AF-37E7EAF682B5}"),
                    EmergencyId = Guid.Parse("231D86A8-97CB-4B12-B734-4C72FD8E6C67"),
                    Step = 6,
                    TopContent = @"Thoát khỏi nguy hiểm",
                    MainPictureUrl = "xacdinhphuonghuong_main_step_6",
                    ActionContent = "Đường thẳng này sẽ chỉ hướng Đông - Tây.",
                    IsSafe = true
                },
            #endregion

            #region Tín hiệu cầu cứu Id = Guid.Parse("39047891-AE02-4927-849B-A950F85F4480"),
                new EmergencyDetail
                {
                    Id = GuidParse("{81725D34-8224-438C-995E-2A02006295FB}"),
                    EmergencyId = Guid.Parse("39047891-AE02-4927-849B-A950F85F4480"),
                    Step = 1,
                    TopContent = @"Truyền thông tin để xin giúp đỡ",
                    MainPictureUrl = "sos_main_step_1",
                    ActionContent = "Chuẩn bị cây khô hoặc đá",
                    IsSafe = true
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{AA158C9C-5A68-4059-B1AE-E4085ADCD51F}"),
                    EmergencyId = Guid.Parse("39047891-AE02-4927-849B-A950F85F4480"),
                    Step = 2,
                    TopContent = @"Truyền thông tin để xin giúp đỡ",
                    MainPictureUrl = "sos_main_step_2",
                    ActionContent = "Viết chữ SOS lên mặt đất",
                    IsSafe = true
                },
            #endregion

            #region Thắt nút dây Guid.Parse("280F5A0E-0379-4B8E-A09D-AACDA21CDDAF"),
                new EmergencyDetail
                {
                    Id = GuidParse("{41FA54BE-CB59-42AD-A6BD-48F705B7BD7A}"),
                    EmergencyId = Guid.Parse("280F5A0E-0379-4B8E-A09D-AACDA21CDDAF"),
                    Step = 1,
                    TopContent = @"Buộc thuyền, dây thừng, dây liều...",
                    MainPictureUrl = "thatnutdaythuyendai_main_step_1",
                    ActionContent = "Luồn đầu dây tự do qua dưới vòng dây vừa tạo.",
                    IsSafe = true
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{910CAE89-7155-499F-8B69-0071B959FE59}"),
                    EmergencyId = Guid.Parse("280F5A0E-0379-4B8E-A09D-AACDA21CDDAF"),
                    Step = 2,
                    TopContent = @"Buộc thuyền, dây thừng, dây liều...",
                    MainPictureUrl = "thatnutdaythuyendai_main_step_2",
                    ActionContent = "Vòng đầu dây tự do qua vòng dây một lần nữa, theo hướng từ dưới lên trên.",
                    IsSafe = true
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{905A8CA1-92EF-445F-A4AA-1838D653AF5B}"),
                    EmergencyId = Guid.Parse("280F5A0E-0379-4B8E-A09D-AACDA21CDDAF"),
                    Step = 3,
                    TopContent = @"Buộc thuyền, dây thừng, dây liều...",
                    MainPictureUrl = "thatnutdaythuyendai_main_step_3",
                    ActionContent = "Siết chặt nút bằng cách kéo hai đầu dây.",
                    IsSafe = true
                },
            #endregion 

            #region Ngộ độc Id = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                new EmergencyDetail
                {
                    Id = GuidParse("{2563E2FA-324F-41A0-B780-7034FB55152B}"),
                    EmergencyId = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                    Step = 1,
                    TopContent = @"Ngăn chặn chất độc xâm nhập cơ thể",
                    MainPictureUrl = "ngodoc_main_step_1",
                    ActionContent = "Cho người bệnh uống 1 ly nước muối pha loãng",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{3985BBAA-790D-4301-A500-02C0FEAC422F}"),
                    EmergencyId = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                    Step = 2,
                    TopContent = @"Ngăn chặn chất độc xâm nhập cơ thể",
                    MainPictureUrl = "ngodoc_main_step_2",
                    ActionContent = "Dùng ngón trỏ móc, ngoáy vào vị trí góc cuống lưỡi",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{886CEE20-5A0A-4F87-A059-AA0759C065D4}"),
                    EmergencyId = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                    Step = 3,
                    TopContent = @"Ngăn chặn chất độc xâm nhập cơ thể",
                    MainPictureUrl = "ngodoc_main_step_3",
                    ActionContent = "Sử dụng dung dịch nước bù điện giải ",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{BC199684-DE95-437C-8D1A-8C1E8F6CC1D2}"),
                    EmergencyId = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                    Step = 4,
                    TopContent = @"Ngăn chặn chất độc xâm nhập cơ thể",
                    MainPictureUrl = "ngodoc_main_step_4",
                    ActionContent = "Theo dõi nhịp tim",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{8D5D44F6-39A9-4483-B121-BA884210360A}"),
                    EmergencyId = Guid.Parse("D390145B-B53A-4CCC-AFE3-BB9B218332C0"),
                    Step = 5,
                    TopContent = @"Ngăn chặn chất độc xâm nhập cơ thể",
                    MainPictureUrl = "ngodoc_main_step_5",
                    ActionContent = "Đưa đến cơ sở y tế",
                    IsSafe = true
                },
            #endregion

            #region Ngất Id = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                new EmergencyDetail
                {
                    Id = GuidParse("{CEC9CAB3-BEAF-440E-88EF-91452DC4B077}"),
                    EmergencyId = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                    Step = 1,
                    TopContent = @"Giúp nạn nhân hồi tỉnh",
                    MainPictureUrl = "ngat_main_step_1",
                    ActionContent = "Gọi 115",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{CECA8B5D-A8C6-457F-A681-EEBCFACFE9F4}"),
                    EmergencyId = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                    Step = 2,
                    TopContent = @"Giúp nạn nhân hồi tỉnh",
                    MainPictureUrl = "ngat_main_step_2",
                    ActionContent = "Đặt nạn nhân nằm ngửa",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{346A6CE7-FD63-4788-9C8D-72DA3A606B20}"),
                    EmergencyId = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                    Step = 3,
                    TopContent = @"Giúp nạn nhân hồi tỉnh",
                    MainPictureUrl = "ngat_main_step_3",
                    ActionContent = "Kiểm tra mạch, nhịp tim, nhịp thở",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{E66354A9-760D-4826-A002-04A81BA09C8D}"),
                    EmergencyId = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                    Step = 4,
                    TopContent = @"Giúp nạn nhân hồi tỉnh",
                    MainPictureUrl = "ngat_main_step_4",
                    ActionContent = "Hô hấp nhân tạo và ép tim ngoài lồng ngực ",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{9E6064B5-DB1E-456F-B113-0034F1A6FDD4}"),
                    EmergencyId = Guid.Parse("4DE6137F-63C7-4E2B-876C-F6084CADD849"),
                    Step = 5,
                    TopContent = @"Giúp nạn nhân hồi tỉnh",
                    MainPictureUrl = "ngat_main_step_5",
                    ActionContent = "Ghi lại thời gian ngất xỉu và các triệu chứng",
                    IsSafe = true
                },
            #endregion

            #region Chảy máu cam Id = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                new EmergencyDetail
                {
                    Id = GuidParse("{D3A98AF4-5C3E-4B87-9938-788264FF9A36}"),
                    EmergencyId = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                    Step = 1,
                    TopContent = @"Cầm máu",
                    MainPictureUrl = "chaymaucam_main_step_1",
                    ActionContent = "Ngồi dậy, hơi nghiêng người về phía trước và thở bằng miệng",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{7179302F-70CF-482C-9027-F94ED74FF7A1}"),
                    EmergencyId = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                    Step = 2,
                    TopContent = @"Cầm máu",
                    MainPictureUrl = "chaymaucam_main_step_2",
                    ActionContent = "Dùng ngón tay cái và ngón trỏ bóp phía trước mũi",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{0E6D3177-7510-4290-8AE7-02C7DCF2BD46}"),
                    EmergencyId = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                    Step = 3,
                    TopContent = @"Cầm máu",
                    MainPictureUrl = "chaymaucam_main_step_3",
                    ActionContent = "Chườm túi đá lên sống mũi",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{0A4E0C7B-3455-4D10-A25C-D5D78E84EFB1}"),
                    EmergencyId = Guid.Parse("CDD95A29-4F65-487A-AE60-2F043C4C63F8"),
                    Step = 4,
                    TopContent = @"Cầm máu",
                    MainPictureUrl = "chaymaucam_main_step_4",
                    ActionContent = "Thả tay ra sau khi bịt mũi trong 5 phút",
                    IsSafe = true
                },
            #endregion

            #region Sốt cao Id = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                new EmergencyDetail
                {
                    Id = GuidParse("{116C0F70-7610-4383-9C5F-10CD086F198A}"),
                    EmergencyId = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                    Step = 1,
                    TopContent = @"Cứu sống nạn nhân",
                    MainPictureUrl = "sotcao_main_step_1",
                    ActionContent = "Nằm nghiêng một bên",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{479D98E3-0A00-4294-9678-F0E03BD75048}"),
                    EmergencyId = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                    Step = 2,
                    TopContent = @"Cứu sống nạn nhân",
                    MainPictureUrl = "sotcao_main_step_2",
                    ActionContent = "Nới lỏng quần áo, không đắp mền",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{40F3B8CE-43A1-4256-A8AE-9D96EA94F127}"),
                    EmergencyId = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                    Step = 3,
                    TopContent = @"Cứu sống nạn nhân",
                    MainPictureUrl = "sotcao_main_step_3",
                    ActionContent = "Dùng khăn chườm mát cơ thể",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{6E3BD858-0DAD-4CFB-AD3C-18EA0A51BA59}"),
                    EmergencyId = Guid.Parse("A1969ABB-E4EA-4F53-8CE2-E13136591218"),
                    Step = 4,
                    TopContent = @"Cứu sống nạn nhân",
                    MainPictureUrl = "sotcao_main_step_4",
                    ActionContent = "Đưa đến ngay cơ sở y tế gần nhất",
                    IsSafe = true
                },
            #endregion

            #region Lả nhiệt Id = Guid.Parse("E6E9F4CA-33EC-4DF4-A15F-BB69C61A4691"),
                new EmergencyDetail
                {
                    Id = GuidParse("{0C3AA435-C958-4152-A7A6-309BF52337D0}"),
                    EmergencyId = Guid.Parse("E6E9F4CA-33EC-4DF4-A15F-BB69C61A4691"),
                    Step = 1,
                    TopContent = @"Duy trì thân nhiệt",
                    MainPictureUrl = "hathannhiet_main_step_1",
                    ActionContent = "Đắp chăn lên người họ",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{2E524ACA-1A0F-4125-A7C7-DA24663D327B}"),
                    EmergencyId = Guid.Parse("E6E9F4CA-33EC-4DF4-A15F-BB69C61A4691"),
                    Step = 2,
                    TopContent = @"Duy trì thân nhiệt",
                    MainPictureUrl = "hathannhiet_main_step_2",
                    ActionContent = "Gọi 115",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{F4F0A748-18A6-4546-B4D0-62AC473C7394}"),
                    EmergencyId = Guid.Parse("E6E9F4CA-33EC-4DF4-A15F-BB69C61A4691"),
                    Step = 3,
                    TopContent = @"Duy trì thân nhiệt",
                    MainPictureUrl = "hathannhiet_main_step_3",
                    ActionContent = "Cho họ dùng đồ uống ấm ",
                    IsSafe = true
                },
            #endregion

            #region Sốc nhiệt Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                new EmergencyDetail
                {
                    Id = GuidParse("{0DE1B351-990B-49D2-B1D9-AFF6F2F6C0E2}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 1,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_1",
                    ActionContent = "Gọi 115",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{AF068E17-D32C-43E2-9F3A-AF0602FF6731}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 2,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_2",
                    ActionContent = "Đo thân nhiệt",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{80CA4742-E86A-4B7E-B1DE-7D71184EE956}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 3,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_3",
                    ActionContent = "Cởi bỏ bớt quần áo",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{57B75328-BA3B-4C89-AF42-F3F98F6460EC}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 4,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_4",
                    ActionContent = "Dùng nước xịt nhẹ lên người",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{5E313FDA-E478-4F37-9BD8-2310ED956E41}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 5,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_5",
                    ActionContent = "Lau mát nách, cổ",
                },
                new EmergencyDetail
                {
                    Id = GuidParse("{2803F828-F218-4EAE-B560-19B1C4903C96}"),
                    EmergencyId = Guid.Parse("6AD7EBCD-55B2-419C-AB60-8FCD257C3E1A"),
                    Step = 6,
                    TopContent = @"Hạ thân nhiệt",
                    MainPictureUrl = "socnhiet_main_step_6",
                    ActionContent = "Đắp túi đá lạnh lên khắp cơ thể người bệnh",
                    IsSafe = true,
                },
            #endregion

            #region Tổn thương mắt Id = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("AED8237A-800E-47DA-8AA7-B8935B0D4401"),
                    EmergencyId = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                    Step = 1,
                    TopContent = @"Giảm thiểu tổn thương mắt",
                    MainPictureUrl = "tonthuongmat_main_step_1",
                    ActionContent = "Sử dụng túi chườm lạnh trong 15-20 phút",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("17676CE9-6D78-489B-8803-A651875391E9"),
                    EmergencyId = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                    Step = 2,
                    TopContent = @"Giảm thiểu tổn thương mắt",
                    MainPictureUrl = "tonthuongmat_main_step_2",
                    ActionContent = "Lót bông đệm xung quanh mắt bị tổn thương ",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("B1B7706A-3FAA-4943-A8B2-6D3854A47EC4"),
                    EmergencyId = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                    Step = 3,
                    TopContent = @"Giảm thiểu tổn thương mắt",
                    MainPictureUrl = "tonthuongmat_main_step_3",
                    ActionContent = "Sử dụng băng y tế quấn quanh đầu",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("3FCE95FA-36D0-452F-912F-A66689BCD54F"),
                    EmergencyId = Guid.Parse("558F2622-5BA7-4F13-8086-B7BF91970FA0"),
                    Step = 4,
                    TopContent = @"Giảm thiểu tổn thương mắt",
                    MainPictureUrl = "tonthuongmat_main_step_4",
                    ActionContent = "Đưa bệnh nhân đến bệnh viện",
                    IsSafe = true
                },
            #endregion

            #region Bỏng Id = Guid.Parse("46F2F761-1478-44FD-ADAE-FF50940EA9AA"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("22034197-B916-4C2A-B8B5-CC60EC336B20"),
                    EmergencyId = Guid.Parse("46F2F761-1478-44FD-ADAE-FF50940EA9AA"),
                    Step = 1,
                    TopContent = @"Giảm thiểu bị tổn thương nặng về da",
                    MainPictureUrl = "bong_main_step_1",
                    ActionContent = "Ngâm vào nước nguội sạch để vệ sinh vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("BA4B51A1-460C-4A32-801E-1C65B8D624B5"),
                    EmergencyId = Guid.Parse("46F2F761-1478-44FD-ADAE-FF50940EA9AA"),
                    Step = 2,
                    TopContent = @"Giảm thiểu bị tổn thương nặng về da",
                    MainPictureUrl = "bong_main_step_2",
                    ActionContent = "Xả nhẹ nước mát trong 15 phút",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("C88D5F35-4C11-42A4-B355-D0052B08687E"),
                    EmergencyId = Guid.Parse("46F2F761-1478-44FD-ADAE-FF50940EA9AA"),
                    Step = 3,
                    TopContent = @"Giảm thiểu bị tổn thương nặng về da",
                    MainPictureUrl = "bong_main_step_3",
                    ActionContent = "Sử dụng gạc sạch để băng vùng da bị bỏng",
                    IsSafe = true
                },
            #endregion

            #region Bong gân Id = Guid.Parse("6A30DBFE-0C1C-4D34-B968-52BF9DABB48E"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("B8DA47D7-EDD8-484A-B06D-691A07B2739F"),
                    EmergencyId = Guid.Parse("6A30DBFE-0C1C-4D34-B968-52BF9DABB48E"),
                    Step = 1,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "bonggan_main_step_1",
                    ActionContent = "Chườm lạnh vùng bị thương ",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("07F89298-3FE2-4F16-A33D-209A7FEB9526"),
                    EmergencyId = Guid.Parse("6A30DBFE-0C1C-4D34-B968-52BF9DABB48E"),
                    Step = 2,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "bonggan_main_step_2",
                    ActionContent = "Ngâm nước ấm sau khoảng 2 ngày chườm lạnh ",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("BF2EA4B1-05DB-4175-96CA-87008A609FE9"),
                    EmergencyId = Guid.Parse("6A30DBFE-0C1C-4D34-B968-52BF9DABB48E"),
                    Step = 3,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "bonggan_main_step_3",
                    ActionContent = "Sử dụng băng vải băng vùng bị bong gân ",
                    IsSafe = true
                },
            #endregion

            #region Giẫm đinh Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("40F9158A-50BB-4800-B104-7F43F452B4DA"),
                    EmergencyId = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                    Step = 1,
                    TopContent = @"Ngăn ngừa nhiễm trùng",
                    MainPictureUrl = "kimtimdam_main_step_1",
                    ActionContent = "Rút đinh ra",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("D53D9426-A3D9-401C-B7B3-7AF4974A6572"),
                    EmergencyId = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                    Step = 2,
                    TopContent = @"Ngăn ngừa nhiễm trùng",
                    MainPictureUrl = "kimtimdam_main_step_2",
                    ActionContent = "Rửa sạch vết thương bằng nước sạch",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("DAB66311-12F2-44CE-8719-83D67E21BFDD"),
                    EmergencyId = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                    Step = 3,
                    TopContent = @"Ngăn ngừa nhiễm trùng",
                    MainPictureUrl = "kimtimdam_main_step_3",
                    ActionContent = "Sát trùng vết thương bằng dung dịch sát khuẩn",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("9AE701B5-C513-4D0B-A2B1-EEF8EF995E18"),
                    EmergencyId = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                    Step = 4,
                    TopContent = @"Ngăn ngừa nhiễm trùng",
                    MainPictureUrl = "kimtimdam_main_step_4",
                    ActionContent = "Dùng gạc băng hở vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("A6205571-BE0E-4B95-9FFD-A5ADDEDB4BD7"),
                    EmergencyId = Guid.Parse("EF525797-2EC8-405E-9EB9-826B621FE47A"),
                    Step = 5,
                    TopContent = @"Ngăn ngừa nhiễm trùng",
                    MainPictureUrl = "kimtimdam_main_step_5",
                    ActionContent = "Tiêm phòng uốn ván",
                    IsSafe = true,
                },
            #endregion

            #region Kim tim đâm Id = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"), <=>
                new EmergencyDetail
                {
                    Id = Guid.Parse("A5F66DD3-7F64-4F32-90B3-19A8615380AB"),
                    EmergencyId = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                    Step = 1,
                    TopContent = @"Giảm nguy cơ lây nhiễm",
                    MainPictureUrl = "giamdinh_main_step_1",
                    ActionContent = "Lấy các dụng cụ sắc nhọn ra khỏi cơ thể",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("94C10218-2F11-4892-A64D-2C729F254536"),
                    EmergencyId = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                    Step = 2,
                    TopContent = @"Giảm nguy cơ lây nhiễm",
                    MainPictureUrl = "giamdinh_main_step_2",
                    ActionContent = "Rửa sạch vết thương bằng nước sạch",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("15F7C3E2-71BF-4C82-95A7-D49EF1B76E99"),
                    EmergencyId = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                    Step = 3,
                    TopContent = @"Giảm nguy cơ lây nhiễm",
                    MainPictureUrl = "giamdinh_main_step_3",
                    ActionContent = "Sát trùng vết thương bằng dung dịch sát khuẩn",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("8C19130D-A281-47F4-9753-697267F4ECBD"),
                    EmergencyId = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                    Step = 4,
                    TopContent = @"Giảm nguy cơ lây nhiễm",
                    MainPictureUrl = "giamdinh_main_step_4",
                    ActionContent = "Băng vết thương bằng gạc",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("AA97700C-2471-4845-87C7-4D5D19E4E835"),
                    EmergencyId = Guid.Parse("0D085BFA-8D7E-496B-B86E-FF4F60198269"),
                    Step = 5,
                    TopContent = @"Giảm nguy cơ lây nhiễm",
                    MainPictureUrl = "giamdinh_main_step_5",
                    ActionContent = "Đưa đến cơ sở y tế gần nhất",
                    IsSafe = true,
                },
            #endregion

            #region Gãy xương Id = Guid.Parse("1F7BFE1C-B663-4F08-9713-83394F85319D"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("2162F4CD-ABE5-4945-AC9C-49C2E12ACC88"),
                    EmergencyId = Guid.Parse("1F7BFE1C-B663-4F08-9713-83394F85319D"),
                    Step = 1,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "gayxuong_main_step_1",
                    ActionContent = "Gọi cấp cứu 115",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("CD8EB190-A455-4F5F-BC21-8900C829AD46"),
                    EmergencyId = Guid.Parse("1F7BFE1C-B663-4F08-9713-83394F85319D"),
                    Step = 2,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "gayxuong_main_step_2",
                    ActionContent = "Cố định tạm thời xương gãy bằng nẹp hoặc băng ép",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("EEBEEF97-4736-476C-99AF-DFD4ED9F5255"),
                    EmergencyId = Guid.Parse("1F7BFE1C-B663-4F08-9713-83394F85319D"),
                    Step = 3,
                    TopContent = @"Giảm đau sưng",
                    MainPictureUrl = "gayxuong_main_step_3",
                    ActionContent = "Đặt đầu nạn nhân thấp hơn thân và nâng cao chi gãy",
                    IsSafe = true
                },
            #endregion

            #region Động vật cắn
                //                         Id = Guid.Parse("1F04BEFB-E7A8-4C34-87FE-5A61795FDC2A"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("1AEDFBB6-EF6C-40C3-B5E0-8C11AE6157E4"),
                    EmergencyId = Guid.Parse("1F04BEFB-E7A8-4C34-87FE-5A61795FDC2A"),
                    Step = 1,
                    TopContent = @"Hạn chế tối đa nguy cơ nhiễm trùng",
                    MainPictureUrl = "dongvat_main_step_1",
                    ActionContent = "Rửa vết thương bằng nước sạch",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("B07906A8-521B-4970-A421-2CC61520F749"),
                    EmergencyId = Guid.Parse("1F04BEFB-E7A8-4C34-87FE-5A61795FDC2A"),
                    Step = 2,
                    TopContent = @"1. Bảo vệ vết thương
2. Giảm vi khuẩn từ môi trường",
                    MainPictureUrl = "dongvat_main_step_2",
                    ActionContent = "Băng vô trùng ở vị trí vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("7F0B42F9-0602-4A55-B9D8-CED88911E477"),
                    EmergencyId = Guid.Parse("1F04BEFB-E7A8-4C34-87FE-5A61795FDC2A"),
                    Step = 3,
                    TopContent = @"Ngăn ngừa bệnh dại",
                    MainPictureUrl = "dongvat_main_step_3",
                    ActionContent = "Chích ngừa uốn ván",
                    IsSafe = true
                },

            #endregion

            #region Trụy tim Id = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("DF288229-2DA4-4832-9913-70C1A7E05E8F"),
                    EmergencyId = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                    Step = 1,
                    TopContent = @"Duy trì sự sống cho nạn nhân",
                    MainPictureUrl = "truytim_main_step_1",
                    ActionContent = "Gọi 115",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("AC02F0ED-E9BE-4CFA-99C8-2AA060954BD9"),
                    EmergencyId = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                    Step = 2,
                    TopContent = @"Duy trì sự sống cho nạn nhân",
                    MainPictureUrl = "truytim_main_step_2",
                    ActionContent = "Đỡ đầu và vai nạn nhân, đặt đệm lót dưới đầu gối của họ",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("29EF856C-1CEB-4CE4-8DE0-ADEBD76D8589"),
                    EmergencyId = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                    Step = 3,
                    TopContent = @"Duy trì sự sống cho nạn nhân",
                    MainPictureUrl = "truytim_main_step_3",
                    ActionContent = "Uống một liều 300 mg thuốc viên aspirin.",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("E091B4CD-98F8-4FE3-97BA-9C016C7822E2"),
                    EmergencyId = Guid.Parse("B2590647-632F-48BB-ADEE-5CD6B9A5FB7F"),
                    Step = 4,
                    TopContent = @"Duy trì sự sống cho nạn nhân",
                    MainPictureUrl = "truytim_main_step_4",
                    ActionContent = "Ghi lại các dấu hiệu của nạn nhân ",
                    IsSafe = true
                },
            #endregion

            #region Hạ đường Huyết Id = Guid.Parse("52A8AEF1-343C-41E0-A97B-6E63FC1AFB5D"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("E848A319-5E9A-4DBA-975D-8C1E5247A97A"),
                    EmergencyId = Guid.Parse("52A8AEF1-343C-41E0-A97B-6E63FC1AFB5D"),
                    Step = 1,
                    TopContent = @"Nâng nhanh lượng đường trong máu",
                    MainPictureUrl = "haduonghuyet_main_step_1",
                    ActionContent = "Kiểm tra chỉ số đường huyết",
                    IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("AA9D9C94-CE3F-42A2-ACFF-84F85608748C"),
                    EmergencyId = Guid.Parse("52A8AEF1-343C-41E0-A97B-6E63FC1AFB5D"),
                    Step = 2,
                    TopContent = @"Nâng nhanh lượng đường trong máu",
                    MainPictureUrl = "haduonghuyet_main_step_2",
                    ActionContent = "Bổ sung đường cho bệnh nhân.",
                    IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("53AB9697-804F-4492-93C7-CFCF2C975C2A"),
                    EmergencyId = Guid.Parse("52A8AEF1-343C-41E0-A97B-6E63FC1AFB5D"),
                    Step = 3,
                    TopContent = @"Nâng nhanh lượng đường trong máu",
                    MainPictureUrl = "haduonghuyet_main_step_3",
                    ActionContent = "Đo lại đường huyết sau 15 phút",
                    IsSafe = true
                },
            #endregion

            #region Co giật Id = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("A4DCA733-6788-469B-9980-6DA0759E8089"),
                    EmergencyId = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                    Step = 1,
                    TopContent = @"Giảm thiểu tổn thương về thần kinh",
                    MainPictureUrl = "cogiat_main_step_1",
                    ActionContent = "Nới lỏng quần áo, thắt lưng",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("F160154B-B34A-49F6-89A8-0F80311D0641"),
                    EmergencyId = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                    Step = 2,
                    TopContent = @"Giảm thiểu tổn thương về thần kinh",
                    MainPictureUrl = "cogiat_main_step_2",
                    ActionContent = "Đặt nạn nhân nằm nghiêng sang bên trái và đặt cao chân phải ",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("2977FA59-3EBE-407C-B804-42C381020F74"),
                    EmergencyId = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                    Step = 3,
                    TopContent = @"Giảm thiểu tổn thương về thần kinh",
                    MainPictureUrl = "cogiat_main_step_3",
                    ActionContent = "Kê vật mềm dưới đầu người bệnh",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("D8F9CC58-73BB-49CB-B8A5-C9693FF067DE"),
                    EmergencyId = Guid.Parse("B7A6E1F1-75FB-4E26-B6F9-420DD470369D"),
                    Step = 4,
                    TopContent = @"Giảm thiểu tổn thương về thần kinh",
                    MainPictureUrl = "cogiat_main_step_4",
                    ActionContent = "Đưa đến cơ sở y tế gần nhất",
                    IsSafe = true
                },
            #endregion

            #region Đột quỵ Id = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("5F589B73-6307-4BA1-9B6E-A0AEA9DBB10A"),
                    EmergencyId = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                    Step = 1,
                    TopContent = @"Giảm thiểu tổn thương não",
                    MainPictureUrl = "dotquy_main_step_1",
                    ActionContent = "Gọi cấp cứu 115",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("1E9DAE67-083C-40A3-9D33-1DE20E22C900"),
                    EmergencyId = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                    Step = 2,
                    TopContent = @"Giảm thiểu tổn thương não",
                    MainPictureUrl = "dotquy_main_step_2",
                    ActionContent = "Kiếm tra nhịp thở và thực hiện hô hấp nhân tạo",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("7978618A-D7BE-4975-8DB9-648A435925CE"),
                    EmergencyId = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                    Step = 3,
                    TopContent = @"Giảm thiểu tổn thương não",
                    MainPictureUrl = "dotquy_main_step_3",
                    ActionContent = "Nới lỏng quần áo, phụ kiện",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("E57DADDB-F9B7-483B-B4AB-153957577E7F"),
                    EmergencyId = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                    Step = 4,
                    TopContent = @"Giảm thiểu tổn thương não",
                    MainPictureUrl = "dotquy_main_step_4",
                    ActionContent = "Dùng khăn tay lấy sạch đờm",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("299B419B-4894-4D0E-820F-E62774AAB8C6"),
                    EmergencyId = Guid.Parse("B8055C5B-A7FE-4D1B-8FBC-5EBD33FAC035"),
                    Step = 5,
                    TopContent = @"Giảm thiểu tổn thương não",
                    MainPictureUrl = "dotquy_main_step_5",
                    ActionContent = "Ghi lại các biểu hiện của người bệnh và đưa tới bệnh viện",
                    IsSafe = true
                },
            #endregion

            #region Đuối nước Id = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("2DE49840-07B0-478C-B045-A46E311BFC2D"),
                    EmergencyId = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                    Step = 1,
                    TopContent = @"Cứu sống nạn nhân trước khi tới bệnh viện",
                    MainPictureUrl = "duoinuoc_main_step_1",
                    ActionContent = "Gọi người hỗ trợ",
                    // // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("EEA55B8B-FA03-4ECB-819A-CA9A6F9D43EF"),
                    EmergencyId = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                    Step = 2,
                    TopContent = @"Cứu sống nạn nhân trước khi tới bệnh viện",
                    MainPictureUrl = "duoinuoc_main_step_2",
                    ActionContent = "Đặt nạn nhân nằm ngửa và hồi sức tim phổi",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("B9EA8984-A752-4AC4-8BF2-E30A90E497D0"),
                    EmergencyId = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                    Step = 3,
                    TopContent = @"Cứu sống nạn nhân trước khi tới bệnh viện",
                    MainPictureUrl = "duoinuoc_main_step_3",
                    ActionContent = "Cởi bỏ quần áo ướt và giữ ấm",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("EFE5F9C2-9615-41B1-A4DB-B229DEA17BEF"),
                    EmergencyId = Guid.Parse("C2D48BF7-05FD-4743-95DB-A32C8D53DE88"),
                    Step = 4,
                    TopContent = @"Cứu sống nạn nhân trước khi tới bệnh viện",
                    MainPictureUrl = "duoinuoc_main_step_4",
                    ActionContent = "Đưa nạn nhân đến cơ sở y tế",
                    IsSafe = true
                },
            #endregion

            #region Điện giật Id = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("0CFF733F-47E0-4656-B356-557D02EF9F9C"),
                    EmergencyId = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                    Step = 1,
                    TopContent = @"Đảm bảo an toàn cho bệnh nhân",
                    MainPictureUrl = "diengiat_main_step_1",
                    ActionContent = "Tắt nguồn điện",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("BC5DB5FE-B982-44E6-A591-B2596CCD5522"),
                    EmergencyId = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                    Step = 2,
                    TopContent = @"Đảm bảo an toàn cho bệnh nhân",
                    MainPictureUrl = "diengiat_main_step_2",
                    ActionContent = "Tách nạn nhân ra khỏi nguồn điện ",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("B8A7EC77-865B-4864-B52C-E0951B48E322"),
                    EmergencyId = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                    Step = 3,
                    TopContent = @"Đảm bảo an toàn cho bệnh nhân",
                    MainPictureUrl = "diengiat_main_step_3",
                    ActionContent = "Hô hấp nhân tạo hoặc ép tim ngoài lồng ngực",
                    // IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("9951C3AA-3245-4A3B-AE23-26339B08ECE0"),
                    EmergencyId = Guid.Parse("D16CCFF2-A7A8-4B9A-80FD-DD8B37AEB3B7"),
                    Step = 4,
                    TopContent = @"Đảm bảo an toàn cho bệnh nhân",
                    MainPictureUrl = "diengiat_main_step_4",
                    ActionContent = "Chuyển tới cơ sở y tế",
                    IsSafe = true
                },
            #endregion

            #region Cầm máu                          Id = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("51328C0E-FEFD-4CF0-8407-9DD7E2E7AFC4"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 1,
                    TopContent = @"Nhanh chóng tiếp cận vết thương",
                    MainPictureUrl = "cammau_main_step_1",
                    ActionContent = "Xác định vị trí chảy máu",
                    ContentBottom = "Chảy máu từ động mạch hoặc chảy máu từ tĩnh mạch"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("89C531DA-3ABC-4859-8337-408D8D556D06"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 2,
                    TopContent = @"Giảm nguy cơ mất máu quá nhiều",
                    MainPictureUrl = "cammau_main_step_2",
                    ActionContent = "Dùng khăn hoặc gạc sạch để ép lên vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("294142FC-8261-4D46-B670-5301CD5CE420"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 3,
                    TopContent = @"1. Giảm áp lực máu
2. Giảm nguy cơ mất máu",
                    MainPictureUrl = "cammau_main_step_3",
                    ActionContent = "Nâng cao vị trí máu chảy so với tim",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("B7667346-A9DF-4869-8EE4-814E44426B77"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 4,
                    TopContent = @"Giảm tốc độ chảy máu",
                    MainPictureUrl = "cammau_main_step_4",
                    ActionContent = "Đặt lực ép liên tục vào vết thương",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("AAA16C5A-126A-43FE-921E-D856958C576B"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 5,
                    TopContent = @"Hạn chế chuyển động của vùng bị tổn thương",
                    MainPictureUrl = "cammau_main_step_5",
                    ActionContent = "Cố định vết thương bằng gạc",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("8DF4266C-FD44-4E86-8CF0-F030CA219E71"),
                    EmergencyId = Guid.Parse("BD166379-995B-449D-B381-DB1FD362BE0C"),
                    Step = 6,
                    TopContent = @"Đánh giá chính xác tình trạng của vết thương",
                    MainPictureUrl = "cammau_main_step_6",
                    ActionContent = "Đi đến bệnh viện gần nhất để khám",
                    IsSafe = true,
                },
            #endregion

            #region Hóc dị vật Id = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("201CAFAB-4D18-461E-83DB-3F15AD9BA19C"),
                    EmergencyId = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                    Step = 1,
                    TopContent = @"Loại bỏ dị vật khỏi đường thở",
                    MainPictureUrl = "hocdivat_main_step_1",
                    ActionContent = "Đặt nạn nhân nằm sấp",
                    IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("9420BBD8-3702-438B-9470-9FA5FFF9A0BA"),
                    EmergencyId = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                    Step = 2,
                    TopContent = @"Loại bỏ dị vật khỏi đường thở",
                    MainPictureUrl = "hocdivat_main_step_2",
                    ActionContent = "Vỗ mạnh 5 lần vào lưng nạn nhân",
                    IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("773C3118-1127-4C00-B8AE-4ACF2FFF8E84"),
                    EmergencyId = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                    Step = 3,
                    TopContent = @"Loại bỏ dị vật khỏi đường thở",
                    MainPictureUrl = "hocdivat_main_step_3",
                    ActionContent = "Lật nạn nhân nằm ngửa",
                    IsSafe = false
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("2B581B39-6FF7-465E-B28D-8E8DBDEF52AA"),
                    EmergencyId = Guid.Parse("A89D9710-D2C2-4327-A604-D97BA4A99D4F"),
                    Step = 4,
                    TopContent = @"Loại bỏ dị vật khỏi đường thở",
                    MainPictureUrl = "hocdivat_main_step_4",
                    ActionContent = "Đặt hai ngón tay vào giữa ngực và ấn mạnh 5 lần",
                    IsSafe = true
                },
            #endregion

            #region Sóc phản vệ
                //                         Id = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                new EmergencyDetail
                {
                    Id = Guid.Parse("350BCBA3-0E35-448A-B6A3-0DA6D377E80E"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 1,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_1",
                    ActionContent = "Đánh giá tình trạng",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("40E1F63E-7E31-4466-BD67-7AEE4C28DD7F"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 2,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_2",
                    ActionContent = "GỌI 115",
                    ContentBottom = "BÁO CÁO TÌNH TRẠNG BỆNH NHÂN"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("A29DAE04-810F-4034-AAD7-E293A28047AA"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 3,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_3",
                    ActionContent = "Điều chỉnh tư thế bệnh nhân",
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("51B70068-3066-4E06-A5BA-BF3CF1D9639F"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 4,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_4",
                    ActionContent = "Nếu bệnh nhân nôn hay chảy máu",
                    ContentBottom = "Lật người bệnh nằm nghiêng"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("CC4601B6-D9F9-4094-BC57-7105AA236761"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 5,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_5",
                    ActionContent = "Nói chuyện liên tục với bệnh nhân",
                    ContentBottom = "Giữ được nhiệp thở tránh trạng thái hôn mê"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("A0AE585B-182F-4DF1-B596-429571D81C3D"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 6,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_6",
                    ActionContent = "Hồi sức tim phổi",
                    ContentBottom = "NẾU BỆNH NHÂN NGƯNG THỞ"
                },
                new EmergencyDetail
                {
                    Id = Guid.Parse("1262623D-475A-4015-BC55-282650E90CDE"),
                    EmergencyId = Guid.Parse("1822976F-01D7-4A12-BA20-46E5004CC71C"),
                    Step = 7,
                    TopContent = @"1. Sơ cấp cứu khẩn cấp
2. Tránh tăng mức độ sốc",
                    MainPictureUrl = "socphanve_main_step_7",
                    ActionContent = "Rà soát nguyên nhân",
                    IsSafe = true,
                    ContentBottom = "KIỂM TRA NGUYÊN NHÂN GÂY SỐC PHẢN VỆ & NGƯNG TIẾP XÚC VỚI TÁC NHÂN GÂY DỊ ỨNG (NẾU CÓ)"
                }
                #endregion
                );
            #region Mini content

            builder.Entity<MiniContent>()
                .HasData(
                new MiniContent
                {
                    Id = Guid.Parse("A2ECD786-F8BD-47F8-8900-BE1407C3CCD0"),
                    EmergencyDetailId = Guid.Parse("350BCBA3-0E35-448A-B6A3-0DA6D377E80E"),
                    Content = "Hô hấp",
                    ContentUrl = "socphanve_step_1_mini_content_1",
                },
                new MiniContent
                {
                    Id = Guid.Parse("27891A29-9107-45A3-812C-766D52779AB7"),
                    EmergencyDetailId = Guid.Parse("350BCBA3-0E35-448A-B6A3-0DA6D377E80E"),
                    Content = "Tuần hoàn",
                    ContentUrl = "socphanve_step_1_mini_content_2",
                },
                new MiniContent
                {
                    Id = Guid.Parse("636AF2B3-96FE-4FED-9E59-23C5C5941A14"),
                    EmergencyDetailId = Guid.Parse("350BCBA3-0E35-448A-B6A3-0DA6D377E80E"),
                    Content = "Ý thức",
                    ContentUrl = "socphanve_step_1_mini_content_3",
                },
                new MiniContent
                {
                    Id = Guid.Parse("E27D22B8-E12D-4906-985C-BCC6A28AEEAB"),
                    EmergencyDetailId = Guid.Parse("A29DAE04-810F-4034-AAD7-E293A28047AA"),
                    Content = "Đặt bệnh nhân nằm tư thế chân cao hơn đầu",
                    ContentUrl = "socphanve_step_3_mini_content_1",
                },
                new MiniContent
                {
                    Id = Guid.Parse("80EE8583-FF0B-49AE-81D2-0E5B0724ADE7"),
                    EmergencyDetailId = Guid.Parse("A29DAE04-810F-4034-AAD7-E293A28047AA"),
                    Content = "Nới lỏng quần áo & đắp chăn",
                    ContentUrl = "socphanve_step_3_mini_content_2",
                },
                new MiniContent
                {
                    Id = Guid.Parse("E5919E2D-642B-46DA-980D-EF68F365C0DA"),
                    EmergencyDetailId = Guid.Parse("A0AE585B-182F-4DF1-B596-429571D81C3D"),
                    Content = "Ép hơi lồng ngực",
                    ContentUrl = "socphanve_step_6_mini_content_1",
                },
                new MiniContent
                {
                    Id = Guid.Parse("CBC76DAC-42DA-4B4B-807D-AAB23B875E93"),
                    EmergencyDetailId = Guid.Parse("A0AE585B-182F-4DF1-B596-429571D81C3D"),
                    Content = "Hà hơi thổi ngạt",
                    ContentUrl = "socphanve_step_6_mini_content_2",
                }
                );

            #endregion

            #region Answer Content
            builder.Entity<AnswerContent>()
                .HasData(
                //Hỏa hoạn step 2
                new AnswerContent
                {
                    Id = Guid.Parse("C125F973-8AF1-417E-87BE-FF5F46FFDF5C"),
                    EmergencyDetailId = Guid.Parse("64D9B4F9-B12A-4C66-9B12-E1F79E4B7878"),
                    Answer = "Có",
                    //NextStepAfterAnswer ??? Chưa nghĩ ra :D 
                },
                new AnswerContent
                {
                    Id = Guid.Parse("58698E2D-FB2A-48C1-B064-085DD11C48D0"),
                    EmergencyDetailId = Guid.Parse("64D9B4F9-B12A-4C66-9B12-E1F79E4B7878"),
                    Answer = "Không",
                    NextStepAfterAnswer = 3
                },
                //Hỏa hoạn step 4
                new AnswerContent
                {
                    Id = Guid.Parse("2A7CE08A-0967-439A-B0AF-D3F0C80197D6"),
                    EmergencyDetailId = Guid.Parse("ABAC6286-767D-4BAA-BC63-2FCC3E70A48E"),
                    Answer = "Tín hiệu đèn",
                    //NextStepAfterAnswer = 3
                },
                new AnswerContent
                {
                    Id = Guid.Parse("6E4CAA08-8B57-4090-8BB4-3507199E0BE3"),
                    EmergencyDetailId = Guid.Parse("ABAC6286-767D-4BAA-BC63-2FCC3E70A48E"),
                    Answer = "Tín hiệu còi",
                    //NextStepAfterAnswer = 3
                }
                );
            #endregion
            #endregion
            #region CategoryCourse
            builder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        Name = "Kiến thức sơ cấp cứu"
                    },
                    new Category
                    {
                        Id = Guid.Parse("2B729EFA-3446-405B-9DC7-059A4C451296"),
                        Name = "Kỹ năng sinh tồn"
                    });
            #endregion
            #region Course Detail
            builder.Entity<CourseDetail>()
                .HasData(
                    // Nguyên Tắc An Toàn
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("2F55AA8B-E887-4808-9E18-7C6556464F16"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
    <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
        Nguyên Tắc An Toàn Trong Sơ Cứu: Bảo Vệ Sức Khỏe Mọi Người
    </h1>
    <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">
        Kiến thức Sơ cấp cứu
    </p>
    <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
        Sơ cứu là một kỹ năng cơ bản mà mỗi người nên biết, vì nó có thể giữ lại mạng sống cho người khác trong những tình huống khẩn cấp. Tuy nhiên, sự hiểu biết về những nguyên tắc an toàn trong quá trình thực hiện sơ cứu cũng quan trọng không kém. Dưới đây là những nguyên tắc quan trọng cần tuân thủ để đảm bảo an toàn cho cả người cứu thương lẫn người bị nạn.
    </p>
    <img
        style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
        src=""https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fsocapcuu.jpg?alt=media&token=8f3138c9-174e-4933-867e-c4ae18095c1f""
        alt=""svg""
    />
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            1. Bảo Vệ Bản Thân Đầu Tiên
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Khi đối mặt với tình huống sơ cứu, quyết định đầu tiên và quan trọng nhất là bảo vệ chính bạn. Đảm bảo rằng không có nguy hiểm nào tiếp tục tồn tại trước khi tiếp cận người bị nạn. Đeo bảo hộ cá nhân nếu có thể, và luôn đánh giá an toàn cho cả mình và người xung quanh.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            2. Gọi Cấp Cứu Trước Khi Hành Động
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trước khi bắt đầu thực hiện bất kỳ biện pháp sơ cứu nào, việc gọi đến số điện thoại cấp cứu là điều quan trọng. Cung cấp thông tin chi tiết về tình hình và tuân theo hướng dẫn từ bác sĩ điều phối giúp đảm bảo có kế hoạch chăm sóc y tế chính xác và nhanh chóng.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            3. Đánh Giá An Toàn Của Môi Trường
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trước khi tiếp cận nạn nhân, hãy đánh giá môi trường xung quanh để đảm bảo an toàn cho cả người cứu thương và người bị nạn. Loại bỏ các nguy cơ tiềm ẩn như lửa, điện áp cao, hoặc vật dụng gây nguy hiểm.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            4. Động Tác Nhẹ Nhàng và Hiệu Quả
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong quá trình thực hiện sơ cứu, hãy luôn tuân thủ nguyên tắc ""động tác nhẹ nhàng"". Tránh gây thêm tổn thương cho nạn nhân và chỉ thực hiện những biện pháp mà bạn đã được đào tạo. Sự nhẹ nhàng kết hợp với hiệu quả sẽ giúp giảm nguy cơ gặp phải tác động phụ không mong muốn.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            5. Đề Xuất Giúp Đỡ Từ Người Xung Quanh
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong một tình huống khẩn cấp, không ngần ngại hỏi xem có ai khác có kỹ năng sơ cứu hay không. Sự hợp tác giữa mọi người có thể tăng khả năng cứu sống và giảm áp lực cho người cứu thương chính.
        </p>
    </div>
    <div style=""margin-top: 40px; margin-bottom: 80px;"">
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Nhớ rằng, việc thực hiện sơ cứu không chỉ là về việc cứu sống mà còn là về cách làm đúng để đảm bảo an toàn cho tất cả mọi người liên quan. Hãy hiểu rõ và áp dụng những nguyên tắc an toàn này để sẵn sàng đối mặt với mọi tình huống khẩn cấp một cách hiệu quả và an toàn.
        </p>
    </div>
</div>
"
                    },
                    // Tư thế nằm nghiêng an toàn
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("F3DB0B18-003A-4046-873B-264D3498360C"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
    <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
       Tư Thế Nằm Nghiêng An Toàn Trong Sơ Cấp Cứu: Biết Để Bảo Vệ Bản Thân và Người Khác
    </h1>
    <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">
        Kiến thức Sơ cấp cứu
    </p>
    <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
        Nhắc đến sơ cấp cứu, việc biết cách giữ tư thế nằm nghiêng an toàn có thể là yếu tố quyết định giữa sự cứu chữa thành công và biến chứng nghiêm trọng. Trong bài viết này, chúng ta sẽ tìm hiểu về các tư thế nằm nghiêng cơ bản mà bạn có thể áp dụng trong các trường hợp khẩn cấp.
    </p>
    <img
        style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
        src=""https://suckhoe123.vn/uploads/suc-khoe/2021_05/20200424_172336_448622_nghieng.max-1800x1800.jpg""
        alt=""svg""
    />
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            Tại sao Tư Thế Nằm Nghiêng Quan Trọng?
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong một số trường hợp, đặc biệt là khi có nguy cơ nôn mửa hoặc hít phải chất lỏng, máu hoặc cơ hội nằm nghiêng có thể ngăn chặn việc phụt ngược chất lỏng vào đường hô hấp, giữ cho đường thoát khí mở rộng và giảm áp lực lên cổ và phổi.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Cách Thực Hiện Tư Thế Nằm Nghiêng
        </p>
    </div>

    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
1. Tư Thế Nằm Nghiêng Đơn Giản:
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            - Đặt người bệnh nằm sấp và kéo một chân về phía trên.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Đặt một bộ phận dưới đầu để giữ cho đầu của họ nghiêng về một bên.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Đảm bảo đầu và cổ của họ đều ở vị trí tự nhiên.
        </p>

    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
            2. Tư Thế Nằm Nghiêng Phức Tạp:
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            - Đặt người bệnh nằm sấp.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Đặt một tấm gối hoặc đối vật cứng dưới người bệnh từ dưới đầu đến dưới đùi của họ.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Kéo một chân của họ về phía trên và đặt gối hoặc chăn dưới chân để giữ cho cơ thể họ nghiêng.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Giữ đầu và cổ của họ trong một tư thế tự nhiên.
        </p>

    </div>
    <div style=""margin-top: 40px; margin-bottom: 80px;"">
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Lưu Ý Quan Trọng
Luôn Giữ Đầu và Cổ Trong Tư Thế Tự Nhiên: Đảm bảo rằng đầu và cổ của người bệnh luôn được giữ trong một tư thế tự nhiên và không bị ép vào bất kỳ hướng nào khi thực hiện tư thế nằm nghiêng.
Theo Dõi Tình Trạng Của Người Bệnh: Luôn lưu ý đến các biểu hiện của người bệnh và sẵn sàng điều chỉnh tư thế nếu cần thiết.
        </p>
    </div>
</div>

"
                    },
                    // Vận chuyển người an toàn 
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("5EF458ED-6776-43B4-BA9D-9CC9C47D7511"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
    <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
Hướng Dẫn Vận Chuyển Người Bệnh An Toàn Trong Mọi Tình Huống
    </h1>
    <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">
        Kiến thức Sơ cấp cứu
    </p>
    <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
        Việc vận chuyển người bệnh là một phần quan trọng trong sơ cứu và chăm sóc y tế. Tuy nhiên, nếu không thực hiện đúng cách, nó có thể gây ra thêm tổn thương và biến chứng cho người bệnh. Trong bài viết này, chúng ta sẽ tìm hiểu về cách vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.
    </p>
    <img
        style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
        src=""https://baoquangbinh.vn/dataimages/202107/original/images704000_cc3.jpg""
        alt=""svg""
    />
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
1. Đánh Giá Tình Hình
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trước khi vận chuyển bất kỳ người bệnh nào, hãy đánh giá tình hình và quyết định liệu có cần gọi xe cấp cứu hay không. Nếu không có xe cấp cứu, đảm bảo rằng bạn có đủ sự trang bị và kiến thức để vận chuyển một cách an toàn.
        </p>
    </div>


    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
2. Chuẩn Bị Môi Trường
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Đảm bảo không gian vận chuyển rộng rãi và an toàn.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Loại bỏ các vật dụng nguy hiểm khỏi lối đi.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Làm cho không gian thoáng đãng và dễ dàng tiếp cận.
        </p>

    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
3. Sử Dụng Kỹ Thuật Đúng
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Sử dụng các kỹ thuật vận chuyển như chuyển lên giường, ghế hoặc xe lăn một cách cẩn thận và nhẹ nhàng.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Luôn sử dụng tư thế bảo vệ cho cơ thể của người bệnh, đặc biệt là đầu, cổ và cột sống.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Sử dụng hỗ trợ bổ sung như gối, băng cố định và dây đai an toàn nếu cần thiết.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
4. Giao Tiếp Và Động Viên
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Luôn giữ liên lạc với người bệnh và cung cấp sự động viên và an ủi.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Giải thích mọi động tác và kế hoạch di chuyển trước khi thực hiện.
        </p>
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
5. Sự Theo Dõi Sau Khi Vận Chuyển
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Sau khi đặt người bệnh vào vị trí mới, đảm bảo rằng họ đang cảm thấy thoải mái và không gặp phải bất kỳ vấn đề nào.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Kiểm tra các dấu hiệu và triệu chứng có thể báo hiệu về tình trạng tồn tại hoặc mới.
        </p>
    </div>


    <div style=""margin-top: 40px; margin-bottom: 80px;"">
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Việc vận chuyển người bệnh đòi hỏi sự chuẩn bị kỹ lưỡng, kiến thức và kỹ năng. Quan trọng nhất là phải luôn đặt sự an toàn và thoải mái của người bệnh lên hàng đầu. Hy vọng rằng với những hướng dẫn trên, bạn sẽ có thêm niềm tin và kiến thức để vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.
        </p>
    </div>
</div>
"
                    },
                    // "CPR - Hồi sinh tim phổi cơ bản",
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("481ABB77-EBD3-47B0-9E9F-718368076074"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
    <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
CPR - Kỹ Năng Hồi Sinh Tim Phổi Cơ Bản Mà Mọi Người Cần Biết    </h1>
    <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">
        Kiến thức Sơ cấp cứu
    </p>
    <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
        Trong một tình huống khẩn cấp khi người khác đột ngột gặp phải ngừng tim phổi, kỹ năng CPR (Cardiopulmonary Resuscitation) - hồi sinh tim phổi là một kỹ năng quan trọng có thể cứu mạng. Trong bài viết này, chúng ta sẽ tìm hiểu về CPR cơ bản và cách thực hiện nó một cách hiệu quả.
    </p>
    <img
        style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
        src=""https://th.bing.com/th/id/R.3c96bb6b124829db33aa812a1814ee9d?rik=dnxzH5j9nJ0rnw&pid=ImgRaw&r=0""
        alt=""svg""
    />
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
CPR là gì?
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            CPR là quá trình cung cấp áp lực hồi sinh tim phổi thông qua việc nén tim và cung cấp hơi thở nhân tạo, nhằm duy trì lưu lượng máu và ôxy đến não và các cơ quan quan trọng khác.
        </p>
    </div>


    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Bước 1: Kiểm Tra An Toàn
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Kiểm tra khu vực xung quanh để đảm bảo an toàn cho bản thân và người bệnh.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Gọi cấp cứu nếu có sẵn.
        </p>
    

    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Bước 2: Kiểm Tra Tình Trạng
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Gọi lên và kiểm tra phản ứng của người bệnh.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Kiểm tra hơi thở và dấu hiệu sống
        </p>
       
    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Bước 3: Báo Cáo Và Bắt Đầu CPR
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Nếu người bệnh không hít thở và không có nhịp tim, bắt đầu CPR ngay lập tức.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Nén tim: Đặt lòng bàn tay ở giữa ngực, nén tim khoảng 5-6cm sâu với tần suất khoảng 100-120 lần mỗi phút.
        </p>
<p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Hơi thở nhân tạo: Thực hiện 2 hơi thở nhân tạo với miệng che miệng và mũi người bệnh.
        </p>

    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Bước 4: Tiếp Tục CPR
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Tiếp tục lặp lại chu trình nén tim và hơi thở cho đến khi cứu thương viên đến hoặc người bệnh hồi phục.
        </p>
    </div>
</div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Lưu Ý Quan Trọng
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Thực hiện CPR một cách nhanh chóng và mạnh mẽ, nhưng đồng thời cẩn thận để tránh gây tổn thương.
Đảm bảo bạn đã được đào tạo và tự tin trước khi thực hiện CPR trên người bệnh.
        </p>
    </div>
<div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Kết luận
        </p>
    </div>


    <div style=""margin-top: 40px; margin-bottom: 80px;"">
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            CPR là một kỹ năng quan trọng mà ai cũng nên biết, vì nó có thể là yếu tố quyết định giữa sự sống và cái chết trong một tình huống khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan về CPR và cung cấp thông tin cần thiết để bạn có thể thực hiện nó một cách hiệu quả khi cần thiết. Hãy nhớ, một phút cứu mạng có thể phát huy tác dụng lớn!
        </p>
    </div>
</div>

"
                    },
                    // Hướng dẫn sơ cứu cho thao tác He
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("7AA3B055-2B09-4D6A-82E0-89E75A365940"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
    <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
Sơ Cứu Cho Thao Tác Heimlich: Biết Cách Cứu Mạng Trong Trường Hợp Hóc Thức Ăn
</h1>
    <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">
        Kiến thức Sơ cấp cứu
    </p>
    <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
        Trong tình huống khẩn cấp khi một người đang bị hóc thức ăn và không thể nói hoặc thở, thao tác Heimlich là một kỹ năng cứu mạng quan trọng. Trong bài viết này, chúng ta sẽ tìm hiểu cách thực hiện thao tác Heimlich một cách đúng đắn để cứu mạng cho người đang bị hóc.
    </p>
    <img
        style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
        src=""https://www.topontiki.gr/wp-content/uploads/2023/08/Untitled-design-2023-08-14T190744.334.jpg""
        alt=""svg""
    />
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
1. Đánh Giá Tình Hình
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;""> 
Trước tiên, hãy đảm bảo rằng người đó thực sự đang bị hóc thức ăn và không thể nói hoặc thở. Nếu họ vẫn có thể nói hoặc ho thở, họ có thể tự giải quyết vấn đề và bạn chỉ cần đề xuất họ làm theo.
        </p>
    </div>


    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
2. Thực Hiện Thao Tác Heimlich
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Đứng phía sau: Đứng phía sau người bị hóc, đặt một chân giữa chân họ để tạo sự ổn định.        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Bám vào phía sau: Đặt một bàn tay lớn vào phía trên của hốc ngực của họ, đặt còn lại vào phía dưới, trên phần dưới của lồng ngực.
        </p>
<p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Thực hiện cú đẩy: Đẩy mạnh và nhanh chóng vào trong và lên trên, hướng ra phía trên, nhưng không đặt quá cao lên phần xương sườn.
        </p>
<p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
- Lặp lại nếu cần thiết: Lặp lại cú đẩy cho đến khi vật thể bị hóc được thải ra hoặc cho đến khi đội cứu hộ đến.
        </p>
    

    </div>
    <div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
3. Sự Theo Dõi Và Hỗ Trợ Sau Khi Thực Hiện
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Theo dõi người bị hóc cho đến khi họ hoàn toàn ổn định.
        </p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
Nếu người bị hóc mất ý thức hoặc ngừng hô hấp, thực hiện CPR ngay lập tức.
        </p>
       
    </div>
    
   
  
<div style=""margin-bottom: 40px;"">
        <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
Kết luận
        </p>
    </div>


    <div style=""margin-top: 40px; margin-bottom: 80px;"">
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
           Thao tác Heimlich là một kỹ năng cứu mạng quan trọng mà mọi người nên biết. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện thao tác Heimlich một cách an toàn và hiệu quả trong trường hợp cần thiết. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi sự thành công trong sơ cứu.
        </p>
    </div>
</div>

"
                    },
                    // Tạo lửa
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("C672EBE0-2A8E-4A0E-B21F-F70E0D87EFA2"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
        <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
            10 Cách thắt nút dây cơ bản mà bạn nên biết
        </h1>
        <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">Kiến thức Sơ cấp cứu</p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong những tình huống khẩn cấp, khả năng tạo lửa có thể là yếu tố quyết định giữa sự sống và cái chết. Dù
            bạn đang dã ngoại, mắc kẹt trong rừng hoặc gặp phải tình huống khẩn cấp khác, biết cách tạo lửa từ những vật
            dụng cơ bản có thể cực kỳ hữu ích. Trong bài viết này, chúng ta sẽ khám phá những cách tạo lửa đơn giản mà
            bất kỳ ai cũng có thể thực hiện.
        </p>
        <img
            style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
            src=""https://st.quantrimang.com/photos/image/2016/11/08/tao-lua-650.jpg""
            alt=""svg""
        />
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                1. Sử dụng đánh lửa
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Một trong những cách đơn giản nhất để tạo lửa là sử dụng đánh lửa hoặc bật lửa di động. Đảm bảo rằng bạn
                luôn giữ một chiếc đánh lửa hoặc bật lửa trong túi hoặc trong hành trang của mình.
            </p>
        </div>

        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                2. Sử Dụng Que Diêm
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Que diêm là một phương tiện khác để tạo lửa nhanh chóng và dễ dàng. Hãy đảm bảo rằng bạn luôn mang theo
                một số que diêm trong túi hoặc hành trang của mình.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                3. Sử Dụng Các Vật Dụng Tự Nhiên
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nếu bạn không có đánh lửa hoặc que diêm, bạn vẫn có thể tạo lửa bằng cách sử dụng các vật dụng tự nhiên
                như cây khô, lá khô, vỏ cây, hoặc cành cây sấy khô dưới ánh nắng mặt trời.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                4. Sử Dụng Kỹ Thuật Friction
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Một kỹ thuật khác để tạo lửa là sử dụng ma sát. Bạn có thể sử dụng hai vật dụng có thể tạo ra ma sát
                mạnh mẽ khi chúng va chạm với nhau như các cành cây, bàn tay, hoặc một miếng vải và một cành cây.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                5. Sử Dụng Kính Lúp
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nếu bạn có một kính lúp, bạn có thể sử dụng nó để tập trung ánh nắng mặt trời vào một điểm nhỏ trên vật
                liệu cháy để tạo nên lửa.
            </p>
        </div>

        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">Kết luận</p>
        </div>

        <div style=""margin-top: 40px; margin-bottom: 80px;"">
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Biết cách tạo lửa từ những vật dụng cơ bản có thể là một kỹ năng quan trọng trong mọi tình huống khẩn
                cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực
                hiện điều này một cách an toàn và hiệu quả. Đừng quên, luôn luôn lưu ý đến sự an toàn khi làm việc với
                lửa.
            </p>
        </div>
    </div>

"
                    },
                    // 10 cách thắt nút dây
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("842765E5-AEC9-402E-93CD-3F3BB3998608"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
        <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
            10 Cách Thắt Nút Dây Cơ Bản Mà Bạn Nên Biết
        </h1>
        <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">Kiến thức Sơ cấp cứu</p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Thắt nút là một trong những kỹ năng cơ bản mà ai cũng nên biết, không chỉ trong các hoạt động dã ngoại mà
            còn trong cuộc sống hàng ngày. Từ việc thắt dây giày đến thắt dây dẹt trên thùng đồ, việc biết cách thắt nút
            một cách đúng đắn có thể giúp bạn giữ dây chặt chẽ và an toàn. Trong bài viết này, chúng ta sẽ khám phá 10
            cách thắt nút dây cơ bản mà bạn nên biết.
        </p>
        <img
            style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
            src=""https://chuyendaychi.com/wp-content/uploads/2018/05/n%C3%BAt-th%E1%BA%AFt-d%C3%A2y-th%E1%BA%A3-di%E1%BB%81u.jpg""
            alt=""svg""
        />
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                1. Nút Dây Dẹt (Overhand Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây dẹt là một trong những nút đơn giản nhất và được sử dụng phổ biến trong cuộc sống hàng ngày. Đây
                là cách thắt nút cơ bản nhất để ngăn dây khỏi tự lỏng ra.
            </p>
        </div>

        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                2. Nút Dây Buộc (Square Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây buộc là một trong những nút được sử dụng rộng rãi để nối hai đoạn dây lại với nhau một cách chắc
                chắn và an toàn.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                3. Nút Dây Chặn (Slip Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây chặn là một loại nút có thể điều chỉnh kích thước và được sử dụng để buộc dây một cách nhanh
                chóng và dễ dàng.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                4. Nút Dây Leo Cây (Clove Hitch)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây leo cây là một nút linh hoạt được sử dụng để buộc dây vào một vật thể tròn như cây hoặc ống.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                5. Nút Dây Buông (Bowline Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây buông là một trong những nút an toàn nhất để tạo ra một lỗ hoặc vòng không bao giờ tự động co
                lại.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                6. Nút Dây Buộc Gói (Package Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây buộc gói là một loại nút được sử dụng để buộc chặt các gói hàng hoặc túi.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                7. Nút Dây Buộc Dính (Sheet Bend)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây buộc dính là một cách tốt để nối hai đoạn dây có đường kính khác nhau lại với nhau một cách chắc
                chắn.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                8. Nút Dây Leo Núi (Figure Eight Knot)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây leo núi là một loại nút được sử dụng rộng rãi trong leo núi và leo dã ngoại vì nó giữ dây chắc
                chắn và không bao giờ tự động co lại.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                9. Nút Dây Buộc Thuyền (Anchor Hitch)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây buộc thuyền là một nút đơn giản được sử dụng để buộc dây vào một đinh, cột hoặc vật thể tương
                tự.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                10. Nút Dây Đồng Đều (Trucker's Hitch)
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nút dây đồng đều là một cách tốt để tạo ra một vòng đeo chắc chắn và được sử dụng rộng rãi trong việc
                buộc chặt và cố định hàng hoặc dụng cụ.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">Kết luận</p>
        </div>

        <div style=""margin-top: 40px; margin-bottom: 80px;"">
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Biết cách thắt nút là một kỹ năng quan trọng và hữu ích trong mọi tình huống. Hy vọng rằng bài viết này
                đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện các loại nút cơ bản một cách
                an toàn và hiệu quả. Hãy thực hành thường xuyên để trở thành một chuyên gia thực sự trong việc thắt nút!
            </p>
        </div>
    </div>

"
                    },
                    // Xác định hướng bằng lá cây ????
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("807EBC7E-3F10-4C2E-B8B2-138B20A314CC"),
                        Content = @"    <div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
        <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
            Bí Quyết Xác Định Phương Hướng Bằng Lá Cây: Kỹ Năng Sinh Tồn Cơ Bản
        </h1>
        <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">Kiến thức Sơ cấp cứu</p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong các tình huống khẩn cấp hoặc khi bị lạc trong thiên nhiên, việc biết cách xác định phương hướng có thể
            là yếu tố quyết định giữa sự sống và cái chết. Mặc dù hiện đại có nhiều công nghệ giúp xác định hướng, nhưng
            việc sử dụng các phương tiện tự nhiên như lá cây vẫn là một kỹ năng cơ bản mà bất kỳ ai cũng nên biết. Trong
            bài viết này, chúng ta sẽ khám phá cách sử dụng lá cây để xác định phương hướng.
        </p>
        <img
            style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
            src=""https://bizweb.dktcdn.net/100/032/885/files/cac-ky-nang-sinh-ton-trong-rung-ban-nen-biet.jpg?v=1664768241728""
            alt=""svg""
        />
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                1. Lá Cây Như Một Dụng Cụ Xác Định Phương Hướng
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Lá cây có thể được sử dụng để xác định hướng chính xác bằng cách nhìn vào cách mà các lá hình dạng và
                màu sắc của chúng thay đổi dựa trên hướng mặt trời.
            </p>
        </div>

        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                2. Hướng Dựa Trên Sự Chiếu Sáng
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Lá Cây Láng: Lá cây sẽ láng hơn ở phía nam so với phía bắc vì mặt trời chiếu sáng trực tiếp vào phía
                nam. Kích Thước Của Bóng Dáng: Khi mặt trời ở trên đỉnh, bóng của cây sẽ nằm ở phía dưới cây về phía
                phía đông. Khi mặt trời ở phía tây, bóng của cây sẽ nằm ở phía dưới cây về phía tây.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                3. Sử Dụng Cây Cây Đồng Thời
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Cây Cây Cây Tập Trung: Các cây sẽ tập trung nhiều ở phía bắc vì phía nam thường có ít ánh sáng mặt trời
                hơn.
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Cây Cây Cây Dày Đặc: Cây sẽ dày đặc hơn ở phía nam do nhận được nhiều ánh sáng mặt trời hơn.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">4. Sự Thực Hành</p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Thực hành thường xuyên và thử nghiệm với lá cây để làm quen với cách chúng phản ánh ánh sáng và hướng
                của mặt trời trong các điều kiện khác nhau.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">Kết luận</p>
        </div>

        <div style=""margin-top: 40px; margin-bottom: 80px;"">
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Biết cách sử dụng lá cây để xác định phương hướng là một kỹ năng cơ bản và quan trọng trong việc sinh
                tồn trong môi trường tự nhiên. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến
                thức cần thiết để thực hiện điều này một cách hiệu quả. Hãy thực hành và trở thành một bậc thầy trong
                việc xác định hướng bằng lá cây!
            </p>
        </div>
    </div>

"
                    },
                    // 5 cách ra tín hiệu cầu cứu
                    new CourseDetail
                    {
                        CourseId = Guid.Parse("1761D6C6-1155-4534-8D44-9362DB753A9A"),
                        Content = @"<div style=""width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;"">
        <h1 style=""font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;"">
            5 Cách Phát Ra Tín Hiệu Cầu Cứu Hiệu Quả Trong Tình Huống Khẩn Cấp
        </h1>
        <p style=""font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;"">Kiến thức Sơ cấp cứu</p>
        <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
            Trong một tình huống khẩn cấp, khả năng phát ra tín hiệu cầu cứu có thể là yếu tố quyết định giữa sự sống và
            cái chết. Tuy nhiên, không phải ai cũng biết cách phát ra tín hiệu cầu cứu một cách hiệu quả. Trong bài viết
            này, chúng ta sẽ khám phá 5 cách phát ra tín hiệu cầu cứu mà bạn nên biết để có thể thu hút sự chú ý và giúp
            đỡ trong một tình huống khẩn cấp.
        </p>
        <img
            style=""width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;""
            src=""https://e.khoahoc.tv/photos/image/2015/07/01/SOS_2.jpg""
            alt=""svg""
        />
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">1. Tiếng Hét Lớn</p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Một trong những cách phổ biến nhất để phát ra tín hiệu cầu cứu là hét lớn. Hãy hét càng to càng tốt để
                thu hút sự chú ý của người xung quanh và gửi đi tín hiệu rằng bạn đang gặp vấn đề và cần sự giúp đỡ.
            </p>
        </div>

        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                2. Sử Dụng Còi Cứu Hộ
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Mang theo một còi cứu hộ là một ý tưởng tốt để có thể phát ra tín hiệu cầu cứu một cách nhanh chóng và
                dễ dàng. Khi gặp phải tình huống khẩn cấp, bạn chỉ cần thổi vào còi một cách mạnh mẽ để thu hút sự chú ý
                của người xung quanh.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                3. Sử Dụng Đèn Pin
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Trong tình huống mà việc gọi cầu cứu bằng tiếng không hiệu quả, việc sử dụng đèn pin có thể là một
                phương tiện hiệu quả khác để thu hút sự chú ý của người xung quanh, đặc biệt là vào ban đêm hoặc trong
                điều kiện ánh sáng yếu.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                4. Sử Dụng Gương Soi Ánh Sáng Mặt Trời
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nếu bạn bị mắc kẹt và không thể di chuyển, việc sử dụng một chiếc gương nhỏ hoặc vật phản quang để soi
                ánh sáng mặt trời có thể là một cách hiệu quả để phát ra tín hiệu cầu cứu và thu hút sự chú ý của người
                đi ngang qua.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">
                5. Sử Dụng Biểu Tượng Cầu Cứu Quốc Tế
            </p>
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Nếu bạn có một biểu tượng cầu cứu quốc tế như biểu tượng SOS, bạn có thể sử dụng nó để tạo ra tín hiệu
                cầu cứu và gửi đi thông điệp rằng bạn đang cần sự giúp đỡ khẩn cấp.
            </p>
        </div>
        <div style=""margin-bottom: 40px;"">
            <p style=""display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;"">Kết luận</p>
        </div>

        <div style=""margin-top: 40px; margin-bottom: 80px;"">
            <p style=""display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;"">
                Biết cách phát ra tín hiệu cầu cứu là một kỹ năng quan trọng và có thể cứu sống trong một tình huống
                khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để
                thực hiện điều này một cách an toàn và hiệu quả. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi
                sự thành công trong tình huống khẩn cấp.
            </p>
        </div>
    </div>

"
                    }
                    );
            #endregion
            #region Course
            builder.Entity<Course>()
                .HasData(
                    new Course
                    {
                        Id = Guid.Parse("2F55AA8B-E887-4808-9E18-7C6556464F16"),
                        Name = "Nguyên tắc an toàn trong sơ cứu",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fnguyentacantoan.png?alt=media&token=d453d651-2618-4ccc-abc4-44a7d26168e8",
                        CategoryId = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        ComboCourseId = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3")
                    },
                    new Course
                    {
                        Id = Guid.Parse("F3DB0B18-003A-4046-873B-264D3498360C"),
                        Name = "Tư thế nằm nghiêng an toàn",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Ftuthenamantoan.png?alt=media&token=b84b752c-668f-4eed-8a23-c2743e97fb1f",
                        CategoryId = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        ComboCourseId = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3")
                    },
                    new Course
                    {
                        Id = Guid.Parse("5EF458ED-6776-43B4-BA9D-9CC9C47D7511"),
                        Name = "Vận chuyển người bệnh an toàn",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fvanchuyennguoibenhantoan.png?alt=media&token=b4aa4bda-dd25-4707-874b-205fc092dccd",
                        CategoryId = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        ComboCourseId = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3")
                    },
                    new Course
                    {
                        Id = Guid.Parse("481ABB77-EBD3-47B0-9E9F-718368076074"),
                        Name = "CPR - Hồi sinh tim phổi cơ bản",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2FCPRhoisinhcapcuu.png?alt=media&token=169fb2c8-5ac3-4926-96f8-13d26c28c78c",
                        CategoryId = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        ComboCourseId = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3")
                    },
                    new Course
                    {
                        Id = Guid.Parse("7AA3B055-2B09-4D6A-82E0-89E75A365940"),
                        Name = "Hướng dẫn sơ cứu cho thao tác Heimlich",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2FsocuuthaotacHeimlich.png?alt=media&token=c2cd2541-914e-4e35-91e4-6b96274060b5",
                        CategoryId = Guid.Parse("3A477216-D412-43CA-B05F-653BC84F6609"),
                        ComboCourseId = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3")
                    },
                    new Course
                    {
                        Id = Guid.Parse("C672EBE0-2A8E-4A0E-B21F-F70E0D87EFA2"),
                        Name = "Tạo lửa từ những vật dụng cơ bản",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Ftaoluatunhungvatdungcoban.png?alt=media&token=6311c2ef-acb7-4efd-bfc4-9becb3464503",
                        CategoryId = Guid.Parse("2B729EFA-3446-405B-9DC7-059A4C451296"),
                        ComboCourseId = Guid.Parse("81E210F8-9274-44C5-9256-481ACCE0E8EC")
                    },
                    new Course
                    {
                        Id = Guid.Parse("842765E5-AEC9-402E-93CD-3F3BB3998608"),
                        Name = "10 cách thắt nút dây cơ bản",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Fthatnutdaycoban.png?alt=media&token=434cd218-d2ee-4e15-823c-fe9158f7eecf",
                        CategoryId = Guid.Parse("2B729EFA-3446-405B-9DC7-059A4C451296"),
                        ComboCourseId = Guid.Parse("81E210F8-9274-44C5-9256-481ACCE0E8EC")
                    },
                    new Course
                    {
                        Id = Guid.Parse("807EBC7E-3F10-4C2E-B8B2-138B20A314CC"),
                        Name = "Xác định phương hướng bằng lá cây",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Fxacdinhphuonghuongbanglacay.png?alt=media&token=03ac5e6c-1922-49af-ab29-d0c2b5a70e5b",
                        CategoryId = Guid.Parse("2B729EFA-3446-405B-9DC7-059A4C451296"),
                        ComboCourseId = Guid.Parse("81E210F8-9274-44C5-9256-481ACCE0E8EC")
                    },
                    new Course
                    {
                        Id = Guid.Parse("1761D6C6-1155-4534-8D44-9362DB753A9A"),
                        Name = "5 cách phát ra tín hiệu cầu cứu hiệu quả",
                        Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2F5cachphattinhieucaucuu.png?alt=media&token=6b75b201-d177-47f9-8741-58c52cfcf656",
                        CategoryId = Guid.Parse("2B729EFA-3446-405B-9DC7-059A4C451296"),
                        ComboCourseId = Guid.Parse("81E210F8-9274-44C5-9256-481ACCE0E8EC")
                    });
            #endregion
            #region ComboCourse
            builder.Entity<ComboCourse>()
            .HasData(
                    new ComboCourse
                    {
                        Id = Guid.Parse("EDD4AE9E-0E26-4ED4-9812-0FBE587FCDB3"),
                        Name = "Freemium"
                    },
                    new ComboCourse
                    {
                        Id = Guid.Parse("81E210F8-9274-44C5-9256-481ACCE0E8EC"),
                        Name = "Premium"
                    });
            #endregion
            #region CategoryKeyword
            builder.Entity<CategoryKeyword>()
            .HasData(
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12"),
                        Name = "Đầu",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("54B8BDD4-B49E-4775-AB42-9FF7B4DD0DF6"),
                        Name = "Mắt",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C"),
                        Name = "Miệng",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027"),
                        Name = "Xương khớp",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2"),
                        Name = "Mũi",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("18FFF9C2-FF95-454C-9556-02DDFAB87C50"),
                        Name = "Tim",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB"),
                        Name = "Cơ thể",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("72C14F87-15AE-4B85-81D1-005562D806C3"),
                        Name = "Bụng",
                        Description = ""
                    },
                    new CategoryKeyword
                    {
                        Id = Guid.Parse("5582C691-4042-40A4-A32B-CDE2EDCB5FE5"),
                        Name = "Trực tràng",
                        Description = ""
                    });
            #endregion
            #region keyword
            builder.Entity<Keyword>()
            .HasData(
                    new Keyword
                    {
                        Id = Guid.Parse("0CB0D678-9454-4391-BD9E-2B536A50F1F7"),
                        Name = "Giảm trí nhớ",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("831C6F2E-7C32-4AE6-8AF6-FDB3897C612B"),
                        Name = "Đau tai",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                        Name = "Đau đầu",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("5490695B-C2D8-4E4D-92E1-690DA77E395D"),
                        Name = "Đau nửa đầu trước",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("16CFEBEA-D7D0-440D-B4BD-43BBFE6610E0"),
                        Name = "Đau nửa đầu sau",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("C4CCE2A8-1B2E-4443-A59E-E4BEC4F2FE0A"),
                        Name = "Tê trán",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("FEDB71A7-BB4B-441A-B30E-0AF28D6D83A3"),
                        Name = "Ù tai",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                        Name = "Chóng mặt",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("C0DAA7C5-4331-44BF-A33E-23679C959B12")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                        Name = "Mắt lờ đờ",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("54B8BDD4-B49E-4775-AB42-9FF7B4DD0DF6")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("3FE4BDF1-EBDF-43DF-868A-09EB274F6F22"),
                        Name = "Đỏ mắt",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("54B8BDD4-B49E-4775-AB42-9FF7B4DD0DF6")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("CD0AA7D8-C354-441D-9ED0-EC97D2E91EF2"),
                        Name = "Đau mắt",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("54B8BDD4-B49E-4775-AB42-9FF7B4DD0DF6")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("7C35E76D-56B9-4EBE-B66A-63E9CE2E9237"),
                        Name = "Chảy nước mắt",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("54B8BDD4-B49E-4775-AB42-9FF7B4DD0DF6")
                    },
                    // Miệng
                    new Keyword
                    {
                        Id = Guid.Parse("BFE028FA-949F-44C8-95C9-FBB4537114C9"),
                        Name = "Sưng tấy nướu",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("91A89827-BDC9-4B2B-A318-65735075A8EB"),
                        Name = "Mất vị giác",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("CE0CED0C-38E6-4BDB-9D66-E5BFDFDC35BA"),
                        Name = "Tê liệt một phần môi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("4B467404-7405-430B-B458-8AACAC949A5B"),
                        Name = "Khó nói chuyện",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("2B11F26C-7206-48A5-801C-9610B99B5738"),
                        Name = "Răng va vào nhau",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("B92E56FC-1BE9-4973-9254-D9CD74A70414"),
                        Name = "Chảy máu chân răng",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("E9619B3B-A906-4ADA-B211-84543A3B31DF"),
                        Name = "Nóng rang cổ họng",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("9BC401F4-517B-4765-885F-1C480893F229"),
                        Name = "Ho khan",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                        Name = "Buồn nôn",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("4F09916E-7A24-455B-BE1E-11340AE4AD68"),
                        Name = "Đau họng",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("1A6C1329-EE6F-4A7D-A5E6-C7DA5D43ED9C")
                    },
                    // xương khớp
                    new Keyword
                    {
                        Id = Guid.Parse("8EF3E270-6C5A-4393-9060-DE98E98E6E84"),
                        Name = "Điềm gồ lên trên da",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("1645E54A-16DB-4C4C-8DE9-3D86F1EE1A36"),
                        Name = "Sưng tấy ngoài da",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("46E01FA7-AF0B-4D0F-8125-56B5772D191B"),
                        Name = "Đau nhói",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("DDBC8B2D-B7E7-445F-9A7B-2194F5AB7704"),
                        Name = "Không thể cử động",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("05EB9523-CBAD-4ABB-97DF-00159D409A78"),
                        Name = "Có tiếng lạo xạo",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("32475E06-C246-437B-9298-4523809622C2"),
                        Name = "Bầm tím",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("04E48A25-DE79-4A3A-88BE-33A8D5829017"),
                        Name = "Điểm gồ lên trên da",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("B8C5CF22-B246-4CA1-B8BF-0F6E7D475027")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("5A876ED2-ED72-40A0-B099-A50BA8028DD3"),
                        Name = "Khó thở",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("76D5C903-E2E0-4D17-A3BB-09B6A8AE6CD4"),
                        Name = "Nghẹt mũi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("73A06B9B-83AB-46B1-90E3-3AA6C2773995"),
                        Name = "Sổ mũi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("2B7A46A0-F703-4DCF-B4F8-66826E128514"),
                        Name = "Chảy máu cam",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("D9D4BA6A-DA09-4482-BF40-E9F9A216CD03"),
                        Name = "Nước mũi có mùi hôi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("25FF2950-58EF-4303-8FC7-0E89538A70B2")
                    },
                    // tim
                    new Keyword
                    {
                        Id = Guid.Parse("514F5B35-23A3-489F-AFC5-9C80511FAB60"),
                        Name = "Đập nhanh",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("18FFF9C2-FF95-454C-9556-02DDFAB87C50")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("7B026EBE-11C7-4585-A395-2B42A4489647"),
                        Name = "Đau nhói nhẹ",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("18FFF9C2-FF95-454C-9556-02DDFAB87C50")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("995FD02A-9F64-45A5-9424-0EC2C9F891A0"),
                        Name = "Đau nhói thường xuyên",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("18FFF9C2-FF95-454C-9556-02DDFAB87C50")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("B51C1608-7F38-427D-B4D7-C9CD62FF253E"),
                        Name = "Cảm giác chèn ép",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("18FFF9C2-FF95-454C-9556-02DDFAB87C50")
                    },
                    // cơ thể
                    new Keyword
                    {
                        Id = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                        Name = "Mệt mỏi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                        Name = "Sốt",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("41455E11-EC85-4698-9A2D-F57C64A45762"),
                        Name = "Chuột rút",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("C55D01CE-F82B-4EF4-B9B2-42452D718E50"),
                        Name = "Đổ mồ hôi lạnh",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("090A2B95-7B45-4600-AD80-DD2853CC9685"),
                        Name = "Mất ngủ",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("7C57B22B-C472-419C-AD81-EE87410C36DE"),
                        Name = "Đau nhứt toàn thân",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("A89744CA-73D3-4F08-9548-9CF8AF8938FB")
                    },
                    // bụng
                    new Keyword
                    {
                        Id = Guid.Parse("0E53C113-06CC-4B91-8FD4-D5C62EA70309"),
                        Name = "Đầy hơi",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("72C14F87-15AE-4B85-81D1-005562D806C3")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("791A9161-5DAB-4FA6-AD27-6B2694AF4E5B"),
                        Name = "Đau bụng",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("72C14F87-15AE-4B85-81D1-005562D806C3")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("A7247C61-4CE6-478C-8C6F-56DF1C72FE1D"),
                        Name = "Đau bụng dưới",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("72C14F87-15AE-4B85-81D1-005562D806C3")
                    },
                    // Trực tràng
                    new Keyword
                    {
                        Id = Guid.Parse("AFCBCBD1-A29A-4647-B7B3-41C1F6FC45F0"),
                        Name = "Đại tiện ra máu",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("5582C691-4042-40A4-A32B-CDE2EDCB5FE5")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("E4B92110-7298-48EA-BBE1-1CC21CCFE6B1"),
                        Name = "Khó đại tiện",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("5582C691-4042-40A4-A32B-CDE2EDCB5FE5")
                    },
                    new Keyword
                    {
                        Id = Guid.Parse("01EA28B2-56FF-44E8-883A-EF8890BD426D"),
                        Name = "Tiêu chảy",
                        Description = "",
                        CategoryKeywordId = Guid.Parse("5582C691-4042-40A4-A32B-CDE2EDCB5FE5")
                    }
                    );
            #endregion
            #region ChuanDoan
            builder.Entity<ChuanDoan>()
            .HasData(
                    new ChuanDoan
                    {
                        Id = Guid.Parse("E71A9882-2634-411F-A74C-3A49AE3989B9"),
                        Name = "Viêm xoang",
                        Description = "Viêm xoang là tình trạng viêm nhiễm các túi khí gần mũi và mắt, thường gây đau đầu và áp lực ở vùng mặt. Điều trị bao gồm thuốc và biện pháp giảm triệu chứng.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F1.png?alt=media&token=b8507450-c048-4ca1-8ded-0bb0f9d8ee43"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        Name = "Cảm lạnh",
                        Description = "Cảm lạnh là một trong những căn bệnh về đường hô hấp thường gặp phải ở trẻ em và người lớn",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F2.png?alt=media&token=9124ffdd-26cf-4702-b5af-f9b6a22e3d5a"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        Name = "Tiêu chảy",
                        Description = "Tiêu chảy là tình trạng mà cơ thể loại bỏ phân đi lỏng hoặc phân nước từ 3 lần/ngày.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F3.png?alt=media&token=01ae1758-b877-4044-bd95-984962050222"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("689782FB-F292-47FB-9E78-990E92A0E390"),
                        Name = "Táo bón",
                        Description = "Táo bón là tình trạng khó đi đại tiện, phân khô cứng, buồn đi đại tiện mà không đi được phải rặn mạnh phân khó thoát ra, thời gian đi lâu hoặc nhiều ngày mới đi một lần.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F4.png?alt=media&token=8e16723e-692c-4d85-ad9d-9c2bae33b4f8"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        Name = "Đau bụng kinh",
                        Description = "Đau bụng kinh (hay thống kinh) là triệu chứng rất phổ biến, liên quan đến chu kỳ kinh nguyệt của nữ giới.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F5.png?alt=media&token=fef3d98d-4a75-43e8-a646-90f6ce108eb2"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        Name = "Viêm Amidan",
                        Description = "Viêm amidan là bệnh phổ biến gặp ở mọi lứa tuổi trong cộng đồng, gây ra những triệu chứng đau rát họng, khó nuốt. Nếu không điều trị sớm có thể dẫn đến những ảnh hưởng sức khỏe nghiêm trọng hơn.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F6.png?alt=media&token=c5ed7f55-00a5-4e1d-9392-2e8d74366f11"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("5E3E996B-CF80-46BE-93A1-E822FDA0D50E"),
                        Name = "Viêm tai giữa",
                        Description = "Viêm tai giữa là một nhóm các bệnh ở tai giữa, là sự tổn thương và viêm nhiễm xuất hiện trong tai giữa do các loại vi khuẩn sinh sôi và phát triển trong tai hoặc bị tác động từ các yếu tố bên ngoài môi trường.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F7.png?alt=media&token=75541064-4a88-4d7b-bad7-6d0d889d78a1"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        Name = "Thiếu máu não",
                        Description = "Thiếu máu não là tình trạng giảm tuần hoàn máu lên não, dẫn tới giảm cung cấp oxy và dưỡng chất cần thiết cho các hoạt động của não bộ ảnh hưởng tới cầu trúc và chức năng của một phần hoặc nhiều phần trên não.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F8.png?alt=media&token=23a73921-2c42-430d-9d81-9891d5d4c421"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        Name = "Huyết áp cao",
                        Description = "Cao huyết áp (hay tăng huyết áp) là một bệnh lý mãn tính khi áp lực của máu tác động lên thành động mạch tăng cao.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F9.png?alt=media&token=0a7613e0-d0bd-4b64-9cd4-6db423f75e39"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        Name = "Covid-19",
                        Description = "Dịch bệnh viêm đường hô hấp cấp do chủng Coronavirus mới (Covid-19) vẫn đang diễn biến rất phức tạp, nó đã lan rộng ra nhiều quốc gia và vùng lãnh thổ khác ngoài Trung Quốc.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F10.png?alt=media&token=326aa412-9ffd-4a44-ae1a-8e6381571c96"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("EEB8AE18-C9A8-485A-9846-C8647D861DC6"),
                        Name = "Viêm nha chu",
                        Description = "Bệnh nha chu là một bệnh nhiễm trùng nướu nghiêm trọng làm tổn thương mô mềm và phá hủy xương xung quanh răng.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F11.png?alt=media&token=19fdb013-bb67-4c08-a1df-a45811cdd546"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("491F2B78-009D-4D2E-8AD7-02C25E44DD95"),
                        Name = "Đột quỵ",
                        Description = "Người bị đột quỵ cần được cấp cứu ngay lập tức, thời gian kéo dài càng lâu, số lượng tế bào não chết càng nhiều sẽ ảnh hưởng lớn tới khả năng vận động và tư duy của cơ thể, thậm chí là tử vong.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F12.png?alt=media&token=aac969a3-f28e-4835-ad03-664e1a6bcc3f"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        Name = "Thiếu máu",
                        Description = "Thiếu máu là tình trạng lượng huyết sắc tốc và số lượng hồng cầu có trong máu ngoại vi bị giảm đi, kết quả là thiếu lượng oxy đến các mô của các tế bào trong cơ thể.\r\n",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F13.png?alt=media&token=87ec19fe-4d4c-4a31-b483-4edd092b37ca"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("59A9E104-7D3B-43A9-AFC1-0C58B3AE4016"),
                        Name = "Rối loạn nhịp tim",
                        Description = "Rối loạn nhịp tim là tình trạng xảy ra khi các xung điện điều khiển nhịp tim hoạt động bất thường, khiến tim đập quá nhanh, quá chậm hoặc không đều. ",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F14.png?alt=media&token=cfc0e696-e3c0-4bb7-8c3e-06278e059fac"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("D343E947-DBBA-4631-9796-9364369EFAC4"),
                        Name = "Chèn ép tim cấp",
                        Description = "Chèn ép tim cấp là một trường hợp cấp cứu, cần được chẩn đoán và xử lý nhanh chóng.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F15.png?alt=media&token=6aeac7f1-056f-42ac-b42f-df01d35ace77"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("ADE4F561-1316-489D-B752-DC042DD5B700"),
                        Name = "Trào ngược axit dạ dày thực quản",
                        Description = "Bệnh trào ngược dạ dày thực quản có thể gây kích ứng niêm mạc thực quản của người bệnh. ",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F16.png?alt=media&token=7ce38317-edbf-4419-b2d5-757aa307880e"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("17617323-50A0-492C-A220-84EA0235735F"),
                        Name = "Đau ruột thừa",
                        Description = "Đau ruột thừa là dấu hiệu cảnh báo ruột thừa đang có vấn đề, thường gặp nhất là viêm ruột thừa, ruột thừa có thể bị vỡ, nguy hiểm đến tính mạng.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F17.png?alt=media&token=5abfa254-9207-401f-a0c7-e26a8dd21758"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("BAC1C26D-FF9F-4CC7-B4BF-F6009B1C5830"),
                        Name = "Rối loạn tiền đình",
                        Description = "Một số người bị rối loạn tiền đình có thể chịu ảnh hưởng nghiêm trọng của bệnh đến cuộc sống hằng ngày cũng như trong học tập.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F18.png?alt=media&token=a53f2edb-e9c2-48fb-ba1b-239e3f4ecf7f"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        Name = "Huyết áp thấp",
                        Description = "Huyết áp thấp sẽ nguy hiểm đến tính mạng nếu như không được phòng tránh và chữa trị kịp thời.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F19.png?alt=media&token=6063eac6-6089-4c1e-b8dc-c3462f6f614d"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("E6513D6E-0D42-480C-925F-7BF931F86CD0"),
                        Name = "Rối loại thần kinh thực vật",
                        Description = "Rối loạn thần kinh thực vật là sự mất cân bằng của hai hệ thống thần kinh giao cảm và phó giao cảm. Bệnh gây đau khiến bệnh nhân gặp phải những hạn chế trong cuộc sống. ",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F20.png?alt=media&token=f2764426-42d0-48b8-abc4-1a0e0e5a7cb8"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        Name = "Viêm kết mạc",
                        Description = "Bệnh viêm kết mạc là bệnh thường gặp, do nhiều nguyên nhân khác nhau gây ra. Bệnh có thể tự khỏi mà không cần điều trị. ",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F21.png?alt=media&token=9e29f660-da22-4402-a06c-399e2daea67c"
                    },
                    new ChuanDoan
                    {
                        Id = Guid.Parse("7BA022BB-325A-4058-A4D9-63892767D7ED"),
                        Name = "Gãy xương đòn",
                        Description = "Gãy xương đòn là gãy xương nằm dài nằm ngay dưới da vùng vai, nối giữa xương ức và hệ thống đai vai – cánh tay, có tác dụng như một thanh chống, giằng giữa thân mình và khớp vai.",
                        UrlImage = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F22.png?alt=media&token=5ed305ab-386a-4c35-ac2b-7707d09780f9"
                    }
              );
            #endregion
            #region ChuanDoan_keyword
            builder.Entity<ChuanDoan_Keyword>(entity =>
            {
                entity.HasKey(cd => new { cd.ChuanDoanId, cd.KeywordId });

                entity.HasOne(cd => cd.ChuanDoan)
                .WithMany(c => c.ChuanDoan_Keyword)
                .HasForeignKey(cd => cd.ChuanDoanId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(cd => cd.Keyword)
                .WithMany(c => c.ChuanDoan_Keyword)
                .HasForeignKey(cd => cd.KeywordId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasData(
                #region viem xoang
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E71A9882-2634-411F-A74C-3A49AE3989B9"),
                        KeywordId = Guid.Parse("5490695B-C2D8-4E4D-92E1-690DA77E395D"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E71A9882-2634-411F-A74C-3A49AE3989B9"),
                        KeywordId = Guid.Parse("76D5C903-E2E0-4D17-A3BB-09B6A8AE6CD4"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E71A9882-2634-411F-A74C-3A49AE3989B9"),
                        KeywordId = Guid.Parse("9BC401F4-517B-4765-885F-1C480893F229"),
                    },
                #endregion
                #region Cảm lạnh
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("73A06B9B-83AB-46B1-90E3-3AA6C2773995"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("76D5C903-E2E0-4D17-A3BB-09B6A8AE6CD4"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("0E53C113-06CC-4B91-8FD4-D5C62EA70309"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("8D4A29C0-775F-49F6-9598-5DBFACCCCED9"),
                        KeywordId = Guid.Parse("4F09916E-7A24-455B-BE1E-11340AE4AD68"),
                    },
                #endregion
                #region Tiêu chảy
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("41455E11-EC85-4698-9A2D-F57C64A45762"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("0E53C113-06CC-4B91-8FD4-D5C62EA70309"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("791A9161-5DAB-4FA6-AD27-6B2694AF4E5B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("984F2FB4-D29C-4959-8A52-1F43F3380DBA"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                #endregion
                #region Táo bón
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("689782FB-F292-47FB-9E78-990E92A0E390"),
                        KeywordId = Guid.Parse("791A9161-5DAB-4FA6-AD27-6B2694AF4E5B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("689782FB-F292-47FB-9E78-990E92A0E390"),
                        KeywordId = Guid.Parse("AFCBCBD1-A29A-4647-B7B3-41C1F6FC45F0"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("689782FB-F292-47FB-9E78-990E92A0E390"),
                        KeywordId = Guid.Parse("E4B92110-7298-48EA-BBE1-1CC21CCFE6B1"),
                    },
                #endregion
                #region Đau bụng kinh
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("A7247C61-4CE6-478C-8C6F-56DF1C72FE1D"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("01EA28B2-56FF-44E8-883A-EF8890BD426D"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("0E53C113-06CC-4B91-8FD4-D5C62EA70309"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("C55D01CE-F82B-4EF4-B9B2-42452D718E50"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("37437D9F-7753-4EE4-A04D-E1CE1651C54F"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                #endregion
                #region Viêm Amidan
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        KeywordId = Guid.Parse("831C6F2E-7C32-4AE6-8AF6-FDB3897C612B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        KeywordId = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        KeywordId = Guid.Parse("9BC401F4-517B-4765-885F-1C480893F229"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0B1820A0-2C22-47AC-80F4-3630863BB890"),
                        KeywordId = Guid.Parse("4F09916E-7A24-455B-BE1E-11340AE4AD68"),
                    },
                #endregion
                #region Viêm tai giữa
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("5E3E996B-CF80-46BE-93A1-E822FDA0D50E"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("5E3E996B-CF80-46BE-93A1-E822FDA0D50E"),
                        KeywordId = Guid.Parse("831C6F2E-7C32-4AE6-8AF6-FDB3897C612B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("5E3E996B-CF80-46BE-93A1-E822FDA0D50E"),
                        KeywordId = Guid.Parse("01EA28B2-56FF-44E8-883A-EF8890BD426D"),
                    },
                #endregion
                #region Thiếu máu não
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("16CFEBEA-D7D0-440D-B4BD-43BBFE6610E0"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("0CB0D678-9454-4391-BD9E-2B536A50F1F7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("090A2B95-7B45-4600-AD80-DD2853CC9685"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("FEDB71A7-BB4B-441A-B30E-0AF28D6D83A3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("0F3633C8-5E37-4F73-B3F6-35933E195046"),
                        KeywordId = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                    },
                #endregion
                #region Huyết áp cao
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        KeywordId = Guid.Parse("61105E2B-B22E-4EB2-897F-941818211986"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        KeywordId = Guid.Parse("5A876ED2-ED72-40A0-B099-A50BA8028DD3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        KeywordId = Guid.Parse("2B7A46A0-F703-4DCF-B4F8-66826E128514"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("AF316D79-6367-4029-A241-BF49FA9C0F56"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                #endregion
                #region Covid-19
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("9BC401F4-517B-4765-885F-1C480893F229"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("91A89827-BDC9-4B2B-A318-65735075A8EB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("01EA28B2-56FF-44E8-883A-EF8890BD426D"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("7C57B22B-C472-419C-AD81-EE87410C36DE"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("5A876ED2-ED72-40A0-B099-A50BA8028DD3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("092CD36A-4A80-48EF-BD7A-F4E3E63871BD"),
                        KeywordId = Guid.Parse("4F09916E-7A24-455B-BE1E-11340AE4AD68"),
                    },
                #endregion
                #region Viêm nha chu
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("EEB8AE18-C9A8-485A-9846-C8647D861DC6"),
                        KeywordId = Guid.Parse("B92E56FC-1BE9-4973-9254-D9CD74A70414"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("EEB8AE18-C9A8-485A-9846-C8647D861DC6"),
                        KeywordId = Guid.Parse("BFE028FA-949F-44C8-95C9-FBB4537114C9"),
                    },
                #endregion
                #region Đột quỵ
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("491F2B78-009D-4D2E-8AD7-02C25E44DD95"),
                        KeywordId = Guid.Parse("CE0CED0C-38E6-4BDB-9D66-E5BFDFDC35BA"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("491F2B78-009D-4D2E-8AD7-02C25E44DD95"),
                        KeywordId = Guid.Parse("4B467404-7405-430B-B458-8AACAC949A5B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("491F2B78-009D-4D2E-8AD7-02C25E44DD95"),
                        KeywordId = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("491F2B78-009D-4D2E-8AD7-02C25E44DD95"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                #endregion
                #region Thiếu máu
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        KeywordId = Guid.Parse("514F5B35-23A3-489F-AFC5-9C80511FAB60"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        KeywordId = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2AE51909-7BAA-4DE0-AE83-C13C0498B157"),
                        KeywordId = Guid.Parse("7B026EBE-11C7-4585-A395-2B42A4489647"),
                    },
                #endregion
                #region Rối loạn nhịp tim
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("59A9E104-7D3B-43A9-AFC1-0C58B3AE4016"),
                        KeywordId = Guid.Parse("514F5B35-23A3-489F-AFC5-9C80511FAB60"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("59A9E104-7D3B-43A9-AFC1-0C58B3AE4016"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("59A9E104-7D3B-43A9-AFC1-0C58B3AE4016"),
                        KeywordId = Guid.Parse("5A876ED2-ED72-40A0-B099-A50BA8028DD3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("59A9E104-7D3B-43A9-AFC1-0C58B3AE4016"),
                        KeywordId = Guid.Parse("B51C1608-7F38-427D-B4D7-C9CD62FF253E"),
                    },
                #endregion
                #region Chèn ép tim cấp
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("D343E947-DBBA-4631-9796-9364369EFAC4"),
                        KeywordId = Guid.Parse("B51C1608-7F38-427D-B4D7-C9CD62FF253E"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("D343E947-DBBA-4631-9796-9364369EFAC4"),
                        KeywordId = Guid.Parse("5A876ED2-ED72-40A0-B099-A50BA8028DD3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("D343E947-DBBA-4631-9796-9364369EFAC4"),
                        KeywordId = Guid.Parse("514F5B35-23A3-489F-AFC5-9C80511FAB60"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("D343E947-DBBA-4631-9796-9364369EFAC4"),
                        KeywordId = Guid.Parse("995FD02A-9F64-45A5-9424-0EC2C9F891A0"),
                    },
                #endregion
                #region Trào ngược axit dạ dày thực quản
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("ADE4F561-1316-489D-B752-DC042DD5B700"),
                        KeywordId = Guid.Parse("E9619B3B-A906-4ADA-B211-84543A3B31DF"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("ADE4F561-1316-489D-B752-DC042DD5B700"),
                        KeywordId = Guid.Parse("9BC401F4-517B-4765-885F-1C480893F229"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("ADE4F561-1316-489D-B752-DC042DD5B700"),
                        KeywordId = Guid.Parse("D9D4BA6A-DA09-4482-BF40-E9F9A216CD03"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("ADE4F561-1316-489D-B752-DC042DD5B700"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                #endregion
                #region Đau ruột thừa
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("17617323-50A0-492C-A220-84EA0235735F"),
                        KeywordId = Guid.Parse("791A9161-5DAB-4FA6-AD27-6B2694AF4E5B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("17617323-50A0-492C-A220-84EA0235735F"),
                        KeywordId = Guid.Parse("F6B44C79-92D9-4128-9D6C-40AA134BF0B2"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("17617323-50A0-492C-A220-84EA0235735F"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("17617323-50A0-492C-A220-84EA0235735F"),
                        KeywordId = Guid.Parse("46E01FA7-AF0B-4D0F-8125-56B5772D191B"),
                    },
                #endregion
                #region Rối loạn tiền đình
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("BAC1C26D-FF9F-4CC7-B4BF-F6009B1C5830"),
                        KeywordId = Guid.Parse("327CA2F9-33CD-421C-B0B2-288582CA465B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("BAC1C26D-FF9F-4CC7-B4BF-F6009B1C5830"),
                        KeywordId = Guid.Parse("FEDB71A7-BB4B-441A-B30E-0AF28D6D83A3"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("BAC1C26D-FF9F-4CC7-B4BF-F6009B1C5830"),
                        KeywordId = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("BAC1C26D-FF9F-4CC7-B4BF-F6009B1C5830"),
                        KeywordId = Guid.Parse("0CB0D678-9454-4391-BD9E-2B536A50F1F7"),
                    },
                #endregion
                #region Huyết áp thấp
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        KeywordId = Guid.Parse("514F5B35-23A3-489F-AFC5-9C80511FAB60"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        KeywordId = Guid.Parse("65A9FD83-5D8B-4E25-93B8-4125D1281AB7"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        KeywordId = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        KeywordId = Guid.Parse("5490695B-C2D8-4E4D-92E1-690DA77E395D"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("2E2C200B-4115-4F49-8516-2A33654C2C00"),
                        KeywordId = Guid.Parse("FEDB71A7-BB4B-441A-B30E-0AF28D6D83A3"),
                    },
                #endregion
                #region Rối loại thần kinh thực vật
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E6513D6E-0D42-480C-925F-7BF931F86CD0"),
                        KeywordId = Guid.Parse("C4CCE2A8-1B2E-4443-A59E-E4BEC4F2FE0A"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E6513D6E-0D42-480C-925F-7BF931F86CD0"),
                        KeywordId = Guid.Parse("46E01FA7-AF0B-4D0F-8125-56B5772D191B"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("E6513D6E-0D42-480C-925F-7BF931F86CD0"),
                        KeywordId = Guid.Parse("090A2B95-7B45-4600-AD80-DD2853CC9685"),
                    },
                #endregion
                #region Viêm kết mạc
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        KeywordId = Guid.Parse("3FE4BDF1-EBDF-43DF-868A-09EB274F6F22"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        KeywordId = Guid.Parse("FD228CDE-7079-4D6A-835B-1DF8215FA5BB"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        KeywordId = Guid.Parse("CE2ACC73-28A0-4DD4-9368-C71C81A60665"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        KeywordId = Guid.Parse("CD0AA7D8-C354-441D-9ED0-EC97D2E91EF2"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("4EDC5C6E-DAA5-48A5-9F1B-D63EE7EB6FC3"),
                        KeywordId = Guid.Parse("7C35E76D-56B9-4EBE-B66A-63E9CE2E9237"),
                    },
                #endregion
                #region Gãy xương đòn
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("7BA022BB-325A-4058-A4D9-63892767D7ED"),
                        KeywordId = Guid.Parse("8EF3E270-6C5A-4393-9060-DE98E98E6E84"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("7BA022BB-325A-4058-A4D9-63892767D7ED"),
                        KeywordId = Guid.Parse("05EB9523-CBAD-4ABB-97DF-00159D409A78"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("7BA022BB-325A-4058-A4D9-63892767D7ED"),
                        KeywordId = Guid.Parse("1645E54A-16DB-4C4C-8DE9-3D86F1EE1A36"),
                    },
                    new ChuanDoan_Keyword
                    {
                        ChuanDoanId = Guid.Parse("7BA022BB-325A-4058-A4D9-63892767D7ED"),
                        KeywordId = Guid.Parse("32475E06-C246-437B-9298-4523809622C2"),
                    }
                    #endregion
                );
            });
            #endregion
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
