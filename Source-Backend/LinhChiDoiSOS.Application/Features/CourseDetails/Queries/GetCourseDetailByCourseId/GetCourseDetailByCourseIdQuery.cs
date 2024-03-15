using AutoMapper;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetCourseDetailByCourseId
{
    public class GetCourseDetailByCourseIdQuery : IRequest<CourseDetailResponse>
    {
        public string CourseId { get; set; }
        public string ApplicationUserId { get; set; }
    }

    public class GetCourseDetailByCourseIdQueryHandler : IRequestHandler<GetCourseDetailByCourseIdQuery, CourseDetailResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetCourseDetailByCourseIdQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<CourseDetailResponse> Handle(GetCourseDetailByCourseIdQuery request, CancellationToken cancellationToken)
        {
            try {
                // check course for freemium
                var course = await _dbContext.Course.Where(c => c.Id == Guid.Parse(request.CourseId)).SingleOrDefaultAsync();
                var comboCourse = await _dbContext.ComboCourse.Where(c => c.Id == course.ComboCourseId).SingleOrDefaultAsync();
                if (comboCourse == null) {
                    throw new NotFoundException("Does not existed comboCourse");
                }
                else {
                    if (comboCourse.Name == "Freemium") {
                        // check course in courseDetail
                        var courseDetail = await _dbContext.CourseDetail
                            .Where(c => c.CourseId == Guid.Parse(request.CourseId) && !c.IsDelete)
                            .SingleOrDefaultAsync();
                        if (courseDetail == null) {
                            throw new NotFoundException("CourseID does not existed");
                        }
                        var response = new CourseDetailResponse
                        {
                            Id = courseDetail.Id,
                            Name = courseDetail.Name,
                            Content = courseDetail.Content,
                            ImageUrl = courseDetail.ImageUrl,
                            StepCourseDetailList = _mapper
                                        .Map<List<StepCourseDetail>>(_dbContext.StepOfCourseDetail
                                                    .Where(s => s.CourseDetailId == courseDetail.Id).ToList()
                                                ),
                            Conlusion = courseDetail.Conlusion,
                            CourseId = courseDetail.CourseId,
                            CourseData = _mapper.Map<CourseResponse>(_dbContext.Course.Where(c => c.Id == courseDetail.CourseId).SingleOrDefault())
                        };
                        return response;
                    }
                    else if (comboCourse.Name == "Premium") {
                        // check coi có booking chưa, chưa có phải throw thông báo đăng kí đi, còn có rồi
                        // thì hiện cho xem
                        var customer = await _dbContext.Customer.Where(c => c.ApplicationUserId == request.ApplicationUserId).SingleOrDefaultAsync();
                        var userHaveBooking = await _dbContext.Booking.Where(u => u.CustomerId == customer.Id).SingleOrDefaultAsync();
                        if (userHaveBooking == null)
                        {
                            throw new BadRequestException("Please register course for experience");
                        }
                        var courseDetail = await _dbContext.CourseDetail
                            .Where(c => c.CourseId == Guid.Parse(request.CourseId) && !c.IsDelete)
                            .SingleOrDefaultAsync();
                        if (courseDetail == null) {
                            throw new NotFoundException("CourseID does not existed");
                        }
                        var response = new CourseDetailResponse
                        {
                            Id = courseDetail.Id,
                            Name = courseDetail.Name,
                            Content = courseDetail.Content,
                            ImageUrl = courseDetail.ImageUrl,
                            StepCourseDetailList = _mapper
                                        .Map<List<StepCourseDetail>>(_dbContext.StepOfCourseDetail
                                                    .Where(s => s.CourseDetailId == courseDetail.Id).ToList()
                                                ),
                            Conlusion = courseDetail.Conlusion,
                            CourseId = courseDetail.CourseId,
                            CourseData = _mapper.Map<CourseResponse>(_dbContext.Course.Where(c => c.Id == courseDetail.CourseId).SingleOrDefault())
                        };
                        return response;
                    }
                }
                return null;
            }
            catch(Exception e) {
                throw new BadRequestException(e.Message);
            }
        }
    }
}
