/*using Duende.IdentityServer.Extensions;
using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Features.Bookings.Commands.CreateBooking;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands.ProcessVnpayPaymentReturn;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Dtos;
using LinhChiDoiSOS.Servicess.VnPay.Config;
using LinhChiDoiSOS.Servicess.VnPay.Response;
using LinhChiDoiSOS.Utils.Extensions;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;

namespace LinhChiDoiSOS.API.Controllers.Payments.Paymentss
{
    [Route("api/v1/payment")]
    [ApiController]
    public class PaymentssController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly VnpayConfig vnpayConfig;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="vnpayConfigOptions"></param>
        public PaymentssController(IMediator mediator,
            IOptions<VnpayConfig> vnpayConfigOptions)
        {
            this.mediator = mediator;
            this.vnpayConfig = vnpayConfigOptions.Value;
        }

        /// <summary>
        /// Create payment to get link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultWithData<PaymentLinkDtos>), 200)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreatePayment request)
        {
            var response = new PaymentLinkDtos();
            response = await mediator.Send(request);
            *//*var booking = new CreateBookingCommand
            {
                Price = request.BookingCourse.Price,
                PaymentId = response.PaymentId,
                CustomerId = request.BookingCourse.CustomerId,
                NameComboCourse = request.BookingCourse.NameComboCourse,
            };
            await mediator.Send(booking);*//*
            return Ok(response);
        }

        [HttpGet]
        [Route("vnpay-return")]
        public async Task<IActionResult> VnpayReturn([FromQuery] VnpayPayResponse response)
        {
            string returnUrl = string.Empty;
            var returnModel = new PaymentReturnDtos();
            var processResult = await mediator.Send(response.Adapt<ProcessVnpayPaymentReturn>());

            if (!processResult.Item2.IsNullOrEmpty()) {
                returnModel = processResult.Item1 as PaymentReturnDtos;
                returnUrl = processResult.Item2 as string;
            }

            if (returnUrl.EndsWith("/"))
                returnUrl = returnUrl.Remove(returnUrl.Length - 1, 1);
            return Redirect($"{returnUrl}?{returnModel.ToQueryString()}");
        }

        *//*[HttpGet]
        [Route("momo-return")]
        public async Task<IActionResult> MomoReturn([FromQuery] MomoOneTimePaymentResultRequest response)
        {
            string returnUrl = string.Empty;
            var returnModel = new PaymentReturnDtos();
            var processResult = await mediator.Send(response.Adapt<ProcessMomoPaymentReturn>());

            if (processResult.Success) {
                returnModel = processResult.Data.Item1 as PaymentReturnDtos;
                returnUrl = processResult.Data.Item2 as string;
            }

            if (returnUrl.EndsWith("/"))
                returnUrl = returnUrl.Remove(returnUrl.Length - 1, 1);
            return Redirect($"{returnUrl}?{returnModel.ToQueryString()}");
        }*//*
    }
}
*/