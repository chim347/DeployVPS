using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.Entities.Payments;
using LinhChiDoiSOS.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Common.Interfaces
{
    public interface ILinhChiDoiSOSDbContext
    {
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
        public DbSet<AnswerContent> AnswerContents { get;set; }
        public DbSet<ChuanDoan> ChuanDoan { get;set; }
        public DbSet<Keyword> Keyword { get;set; }
        public DbSet<CategoryKeyword> CategoryKeyword { get;set; }
        public DbSet<Payment> Payment { get;set; }
        public DbSet<Merchant> Merchant { get;set; }
        public DbSet<PaymentDestination> PaymentDestination { get;set; }
        public DbSet<PaymentNotification> PaymentNotification { get;set; }
        public DbSet<PaymentSignature> PaymentSignature { get;set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get;set; }
        public DbSet<StepOfCourseDetail> StepOfCourseDetail { get;set; }
        public DbSet<ChuanDoan_Keyword> ChuanDoan_Keyword { get; set; }


        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
