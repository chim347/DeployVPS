using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries
{
    public class ChuanDoanResponse : IMapFrom<ChuanDoan>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? UrlImage { get; set; }
        public DateTime? Created { get; set; } // Truyền DateTime bị lỗi ????
    }
}
