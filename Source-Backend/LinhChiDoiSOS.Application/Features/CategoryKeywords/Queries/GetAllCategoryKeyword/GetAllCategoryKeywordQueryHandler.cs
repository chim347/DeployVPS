using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeyword
{
    public class GetAllCategoryKeywordQueryHandler : IRequestHandler<GetAllCategoryKeywordQuery, List<CategoryKeywordResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllCategoryKeywordQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CategoryKeywordResponse>> Handle(GetAllCategoryKeywordQuery request, CancellationToken cancellationToken)
        {
            var categoryKeyword = await _dbContext.CategoryKeyword.Where(c => !c.IsDelete)
                .ProjectTo<CategoryKeywordResponse>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return categoryKeyword;
        }
    }

}
