using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetAllChuanDoan
{
    public class GetAllChuanDoanQueryHandler : IRequestHandler<GetAllChuanDoanQuery, List<ChuanDoanResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllChuanDoanQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<ChuanDoanResponse>> Handle(GetAllChuanDoanQuery request, CancellationToken cancellationToken)
        {
            
            var chuanDoans = await _dbContext.ChuanDoan.Where(c => !c.IsDelete)
                                .ProjectTo<ChuanDoanResponse>(_mapper.ConfigurationProvider)
                                .ToListAsync();
            
            return chuanDoans;
        }
    }
}
