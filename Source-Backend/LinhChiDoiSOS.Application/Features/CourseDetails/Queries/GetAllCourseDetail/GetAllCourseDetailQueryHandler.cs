using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetAllCourseDetail
{
    public class GetAllCourseDetailQueryHandler : IRequestHandler<GetAllCourseDetailQuery, List<CourseDetailResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetAllCourseDetailQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CourseDetailResponse>> Handle(GetAllCourseDetailQuery request, CancellationToken cancellationToken)
        {
            var courseDetailList = await _dbContext.CourseDetail.Where(c => !c.IsDelete)
                                                                .Join(
                                                                    _dbContext.Course,
                                                                    detail => detail.CourseId,
                                                                    course => course.Id,
                                                                    (detail, course) => new CourseDetailResponse
                                                                    {
                                                                        Id = detail.Id,
                                                                        Name = detail.Name,
                                                                        Content = detail.Content,
                                                                        ImageUrl = detail.ImageUrl,
                                                                        StepCourseDetailList = _mapper
                                                                            .Map<List<StepCourseDetail>>(_dbContext.StepOfCourseDetail
                                                                                        .Where(s => s.CourseDetailId == detail.Id)
                                                                                        .OrderBy(s => /*s.StepName*/ s.Created)
                                                                                        .ToList()
                                                                                    ),
                                                                        Conlusion = detail.Conlusion,
                                                                        CourseId = course.Id,
                                                                        CourseData = _mapper.Map<CourseResponse>(course)
                                                                    }
                                                                 ).ToListAsync();

            return courseDetailList;
        }
    }
}
