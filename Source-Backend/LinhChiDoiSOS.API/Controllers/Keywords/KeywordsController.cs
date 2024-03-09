using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Commands.CreateChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetAllChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LinhChiDoiSOS.Application.Features.Keywords.Queries.GetAllKeyword;
using LinhChiDoiSOS.Application.Features.Keywords.Queries;
using LinhChiDoiSOS.Application.Features.Keywords.Commands.CreateKeyword;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.API.Controllers.Keywords
{
    [Route("api/v1/keyword")]
    [ApiController]
    public class KeywordsController : ControllerBase
    {
        private IMediator _mediator;

        public KeywordsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<KeywordResponse>> Get()
        {
            var response = _mediator.Send(new GetAllKeywordQuery());
            return response;
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Task<SOSResponse> Post(CreateKeywordCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }

    }
}
