using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries
{
    public class CategoryKeywordResponse : IMapFrom<CategoryKeyword>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
    }
}
