using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Keyword : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey("CategoryKeywork")]
        public Guid CategoryKeywordId { get; set; }
        
        public virtual ICollection<ChuanDoan_Keyword> ChuanDoan_Keyword { get; set; }
        public virtual CategoryKeyword CategoryKeyword { get; set; }
    }
}
