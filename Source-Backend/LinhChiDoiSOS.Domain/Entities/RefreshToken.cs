using LinhChiDoiSOS.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class RefreshToken : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; } = null!;
        public string RefreshTOken { get; set; } = null!;
        public string? JwtId {  get; set; }  
        public int UsageCount { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked {  get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiredAt { get; set; }


        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
