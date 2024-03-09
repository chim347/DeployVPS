using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Application.Features.Keywords.Queries;
using LinhChiDoiSOS.Domain.Entities;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries
{
    public class CategoryKeywordWithListKeyword
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<KeywordDataResponse> ListKeywordData { get; set; }
    }
}
