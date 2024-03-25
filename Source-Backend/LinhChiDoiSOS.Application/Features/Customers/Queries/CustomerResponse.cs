using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Customers.Queries
{
    public class CustomerResponse
    {
        public CustomerData? CustomerData { get; set; }
        public ApplicationCustomer? ApplicationUserData { get; set; }
    }

    public class CustomerData : IMapFrom<Customer>
    {
        public Guid Id { get; set; }
        public string? ApplicationUserId { get; set; }
        public int IsPremium { get; set; }
        public DateTime? Created { get; set; }

    }

    public class ApplicationCustomer : IMapFrom<ApplicationUser>
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Image { get; set; }
    }
}
