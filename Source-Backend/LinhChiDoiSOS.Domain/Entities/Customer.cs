using LinhChiDoiSOS.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Customer : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        /// <summary>
        /// 0. Chưa đăng ký
        /// 1. Đã gửi đăng ký, đang đợi admin kiểm tra
        /// 2. Premium check!
        /// </summary>
        public int IsPremium { get; set; } = 0;

        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
