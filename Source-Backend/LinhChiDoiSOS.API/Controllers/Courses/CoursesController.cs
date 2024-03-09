using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Courses.Queries;
using LinhChiDoiSOS.Application.Features.Courses.Queries.GetAllCourse;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.API.Controllers.Courses
{
    [Route("api/v1/course")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<CategoryResponse>> Get()
        {
            try {
                var response = await _mediator.Send(new GetAllCourseQuery());
                return response;
            }
            catch (Exception ex) {
                // Log the exception and return an appropriate response.
                throw new BadRequestException("Error at category");
            }
        }
    }
}
