using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Commands.CreateChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetAllChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinhChiDoiSOS.Application.Features.Keywords.Queries.GetAllKeyword;
using LinhChiDoiSOS.Application.Features.Keywords.Commands.CreateKeyword;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeyword;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Commands.CreateCategoryKeyword;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries;

namespace LinhChiDoiSOS.API.Controllers.CategoryKeywords
{
    [Route("api/v1/categorykeyword")]
    [ApiController]
    public class CategoryKeywordsController : ControllerBase
    {
        private IMediator _mediator;

        public CategoryKeywordsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<CategoryKeywordResponse>> Get()
        {
            var response = _mediator.Send(new GetAllCategoryKeywordQuery());
            return response;
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Task<SOSResponse> Post(CreateCategoryKeywordCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
    }
}
