using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Payments.PaymentWithSendMail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.API.Controllers.Payments.PaymentSendMail
{
    [Route("api/v1/payment-send-mail")]
    [ApiController]
    public class PaymentSendMailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentSendMailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> sendMailPayment([FromForm] PaymentWithSendMailQuery request)
        {
            try {
                var result = await _mediator.Send(new PaymentWithSendMailQuery { Email = request.Email });

                return Ok(result);
            }
            catch (Exception ex) {
                throw new BadRequestException("User does not exist.");
            }
        }
    }
}
