using LinhChiDoiSOS.Application.Features.Courses.Queries.GetAllCourse;
using LinhChiDoiSOS.Application.Features.Courses.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.ComboCourses.Queries;
using LinhChiDoiSOS.Application.Features.ComboCourses.Queries.GetAllComboCourse;

namespace LinhChiDoiSOS.API.Controllers.ComboCourses
{
    [Route("api/v1/combo-course")]
    [ApiController]
    public class ComboCoursesController : ControllerBase
    {
        private IMediator _mediator;

        public ComboCoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<ComboCourseResponse>> Get()
        {
            try {
                var response = await _mediator.Send(new GetAllComboCourseQuery());
                return response;
            }
            catch (Exception ex) {
                // Log the exception and return an appropriate response.
                throw new BadRequestException("Error at category");
            }
        }
    }
}
