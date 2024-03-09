using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Keywords.Queries.GetAllKeyword
{
    public class GetAllKeywordQuery : IRequest<List<KeywordResponse>>
    {
    }

    public class GetAllKeywordQueryHandler : IRequestHandler<GetAllKeywordQuery, List<KeywordResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllKeywordQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<KeywordResponse>> Handle(GetAllKeywordQuery request, CancellationToken cancellationToken)
        {
            var keywordList = await _dbContext.Keyword.Where(k => !k.IsDelete).ToListAsync();
            
            var responseList = new List<KeywordResponse>();
            foreach (var keyword in keywordList) {
                var response = new KeywordResponse
                {
                    Id = keyword.Id,
                    Name = keyword.Name,
                    Description = keyword.Description,
                    CategoryKeywordData = _dbContext.CategoryKeyword
                    .Where(c => c.Id == keyword.CategoryKeywordId)
                    .ProjectTo<CategoryKeywordData>(_mapper.ConfigurationProvider)
                    .SingleOrDefault(),
                };
                responseList.Add(response);
            }

            return responseList;
        }

    }
}
