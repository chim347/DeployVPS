using LinhChiDoiSOS.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Admin : BaseAuditableEntity
    {
        public string? Rank { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }


        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
