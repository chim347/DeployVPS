using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Image { get; set; }
    }
}
