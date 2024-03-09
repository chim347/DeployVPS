using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Keywords.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeywordWithListKeyword
{
    public class GetCategoryKeywordWithListKeywordQueryHandler : IRequestHandler<GetCategoryKeywordWithListKeywordQuery, List<CategoryKeywordWithListKeyword>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetCategoryKeywordWithListKeywordQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CategoryKeywordWithListKeyword>> Handle(GetCategoryKeywordWithListKeywordQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _dbContext.CategoryKeyword.Where(c => !c.IsDelete).ToListAsync();
            var categoryKeywordWithKeyword = new List<CategoryKeywordWithListKeyword>();
            foreach (var category in categoryList) {
                var cate = new CategoryKeywordWithListKeyword
                {
                    Id = category.Id,
                    Name = category.Name,
                    ListKeywordData = _mapper.Map<List<KeywordDataResponse>>( _dbContext.Keyword
                                        .Where(k => k.CategoryKeywordId == category.Id && !k.IsDelete)
                                        .ToList())
                };
                categoryKeywordWithKeyword.Add(cate);
            }
            return categoryKeywordWithKeyword;
        }
    }
}
