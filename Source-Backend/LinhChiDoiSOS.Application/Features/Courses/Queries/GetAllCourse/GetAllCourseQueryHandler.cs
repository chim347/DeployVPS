using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.Courses.Queries.GetAllCourse
{
    public class GetAllCourseQueryHandler : IRequestHandler<GetAllCourseQuery, List<CategoryResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        public GetAllCourseQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<List<CategoryResponse>> Handle(GetAllCourseQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _dbContext.Category.Where(c => !c.IsDelete).ToListAsync();
            var response = new List<CategoryResponse>();
            foreach (var category in categoryList) {
                var categoryResponse = new CategoryResponse
                {
                    Id = category.Id,
                    Name = category.Name,
                    CourseResponses = CourseRes(category.Id)
                };
                response.Add(categoryResponse);
            }
            return response;

        }
        #region private
        private List<CourseResponse> CourseRes(Guid categoryId)
        {
            var listCourseByCategoryId = _dbContext.Course
                .Where(c => c.CategoryId == categoryId)
                .ProjectTo<CourseResponse>(_mapper.ConfigurationProvider)
                .ToList();
            return listCourseByCategoryId;
        }
        #endregion
    }
}
