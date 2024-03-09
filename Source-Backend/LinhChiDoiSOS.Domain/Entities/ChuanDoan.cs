using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class ChuanDoan : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? UrlImage {  get; set; }

        public virtual ICollection<ChuanDoan_Keyword> ChuanDoan_Keyword { get; set; }
    }
}
