using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Keywords.Queries
{
    public class KeywordResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CategoryKeywordData? CategoryKeywordData {  get; set; }
    }

    public class CategoryKeywordData : IMapFrom<CategoryKeyword>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }

    public class KeywordDataResponse : IMapFrom<Keyword>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid CategoryKeywordId { get; set; }
    }
}
