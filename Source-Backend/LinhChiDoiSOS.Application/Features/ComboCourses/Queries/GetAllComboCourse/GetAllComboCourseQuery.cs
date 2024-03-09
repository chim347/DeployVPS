using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ComboCourses.Queries.GetAllComboCourse
{
    public class GetAllComboCourseQuery : IRequest<List<ComboCourseResponse>>
    {
    }

    public class GetAllComboCourseQueryHandler : IRequestHandler<GetAllComboCourseQuery, List<ComboCourseResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllComboCourseQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<ComboCourseResponse>> Handle(GetAllComboCourseQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.ComboCourse
                .Where(c => !c.IsDelete)
                .ProjectTo<ComboCourseResponse>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return list;
        }
    }
}
