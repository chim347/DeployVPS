using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Customers.Commands.CreateCustomer;
using LinhChiDoiSOS.Application.Features.Customers.Commands.DeleteCustomer;
using LinhChiDoiSOS.Application.Features.Customers.Commands.UpdateCustomer;
using LinhChiDoiSOS.Application.Features.Customers.Queries;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetAllCustomer;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetCustomerByApplicationUserId;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetCustomerByEmail;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.API.Controllers.Customers
{
    [Route("api/v1/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private  IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{applicationuserid}")]
        public async Task<CustomerResponse> GetById(string applicationuserid)
        {
            var response = await _mediator.Send(new GetByIdQuery
            {
                ApplicationUserId = applicationuserid
            });
            return response;
        }

        [HttpGet]
        [Route("email/{email}")]
        public async Task<CustomerResponse> GetByEmail(string email)
        {
            var response = await _mediator.Send(new GetCustomerByEmailQuery
            {
                Email = email
            });
            return response;
        }

        [HttpGet]
        public async Task<List<CustomerResponse>> Get()
        {
            var response = await _mediator.Send(new GetAllCustomerQuery());
            return response;
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Task<SOSResponse> Post(CreateCustomerCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }

        [HttpPut]
        //[Route("{applicationuserid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public Task<SOSResponse> Put(UpdateCustomerCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        //[Route("{applicationuserid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public Task<SOSResponse> Delete(DeleteCustomerCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
    }
}
