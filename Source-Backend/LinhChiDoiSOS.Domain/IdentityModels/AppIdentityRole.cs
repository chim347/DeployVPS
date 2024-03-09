using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.IdentityModels
{
    public class AppIdentityRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
