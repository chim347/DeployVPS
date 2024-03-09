using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetAllCourseDetail;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetCourseDetailByCourseId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.API.Controllers.CourseDetails
{
    [Route("api/v1/course-detail")]
    [ApiController]
    public class CourseDetailsController : ControllerBase
    {
        private IMediator _mediator;

        public CourseDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<CourseDetailResponse>> Get()
        {
            var response = await _mediator.Send(new GetAllCourseDetailQuery());
            return response;
        }

        [HttpGet]
        [Route("{courseid}/{applicationuserid}")]
        public async Task<CourseDetailResponse> GetById(string courseid, string applicationuserid)
        {
            var response = await _mediator.Send(new GetCourseDetailByCourseIdQuery
            {
                CourseId = courseid,
                ApplicationUserId = applicationuserid
            });
            return response;
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SOSResponse> Post(CreateCourseDetailCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
