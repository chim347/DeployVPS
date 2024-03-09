using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.CategoryCourse.Queries.GetAllCategoryCourse
{
    public class GetAllCategoryCourseQueryHandler : IRequestHandler<GetAllCategoryCourseQuery, List<CategoryCourseResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllCategoryCourseQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CategoryCourseResponse>> Handle(GetAllCategoryCourseQuery request, CancellationToken cancellationToken)
        {
            var categoryResponse = await _dbContext.Category.Where(c => !c.IsDelete)
                .ProjectTo<CategoryCourseResponse>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return categoryResponse;
        }
    }
}
