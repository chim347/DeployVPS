using LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetAllCourseDetail;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Bookings.Commands.CreateBooking;
using LinhChiDoiSOS.Application.Features.Bookings.Queries;

namespace LinhChiDoiSOS.WebAPI.Controllers.Bookings
{
    [Route("api/v1/admin-booking")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private IMediator _mediator;

        public BookingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("add")]
        public async Task<SOSResponse> Create(CreateBookingCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
        [HttpGet]
        [Route("users-are-waitng-for-premium")]
        public async Task<List<CustomerWaitingForPremium>> GetUsersAreWaitingForPremium()
        {
            var response = await _mediator.Send(new GetBookingWaitingCheckCommand());
            return response;
        }
        [HttpGet]
        [Route("users-are-booked-by-time/{starttime}/{endtime}")]
        public async Task<TotalBooked> GetUsersBooked(DateTime starttime, DateTime endtime)
        {
            var request = new GetCustomerBookedCommand()
            {
                StartDate = starttime,
                EndDate = endtime
            };
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
