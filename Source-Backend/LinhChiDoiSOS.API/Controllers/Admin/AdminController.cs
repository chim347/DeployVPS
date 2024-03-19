using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Admins.Commands;
using LinhChiDoiSOS.Application.Features.Customers.Commands.CreateCustomer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.API.Controllers.Admin
{
    [Route("api/v1/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Task<SOSResponse> Post(CreateAdminCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
    }
}
