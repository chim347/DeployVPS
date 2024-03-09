using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class ChuanDoan_Keyword
    {
        public Guid ChuanDoanId { get; set; }
        public Guid KeywordId { get; set; }

        public virtual ChuanDoan? ChuanDoan { get; set; }
        public virtual Keyword? Keyword { get; set; }
    }
}
