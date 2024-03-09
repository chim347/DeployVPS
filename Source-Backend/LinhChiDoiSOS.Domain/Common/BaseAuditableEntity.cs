using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Common
{
    public class BaseAuditableEntity : BaseEntities, ISoftDelete
    {
        public DateTime Created { get; set; }

        public string? CreateBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string? LastModifiedBy { get; set; }

        public bool IsDelete { get; set; }

        protected BaseAuditableEntity()
        {
            Created = DateTime.Now;
            IsDelete = false;
        }
    }
}
