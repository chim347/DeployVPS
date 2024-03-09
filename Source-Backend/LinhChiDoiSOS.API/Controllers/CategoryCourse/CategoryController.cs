using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.CategoryCourse.Commands.CreateCategoryCourse;
using LinhChiDoiSOS.Application.Features.CategoryCourse.Queries;
using LinhChiDoiSOS.Application.Features.CategoryCourse.Queries.GetAllCategoryCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.API.Controllers.CategoryCourse
{
    [Route("api/v1/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [Route("all")]
        public async Task<List<CategoryCourseResponse>> Get()
        {
            var response = await _mediator.Send(new GetAllCategoryCourseQuery());
            return response;
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SOSResponse> Post(CreateCategoryCourseCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
