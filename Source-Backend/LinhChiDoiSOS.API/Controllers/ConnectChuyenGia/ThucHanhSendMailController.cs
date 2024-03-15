using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Payments.PaymentWithSendMail;
using LinhChiDoiSOS.Application.Features.ThucHanhs.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.API.Controllers.ConnectChuyenGia
{
    [Route("api/v1/send-mail-by-doctor")]
    [ApiController]
    public class ThucHanhSendMailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ThucHanhSendMailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> sendMailDoctor([FromForm] ConnectWithDoctoreSendMailQuery request)
        {
            try
            {
                var result = await _mediator.Send(new ConnectWithDoctoreSendMailQuery { Email = request.Email });

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("User does not exist.");
            }
        }
    }
}
