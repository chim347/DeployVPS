using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Commands.CreateCategoryKeyword;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeyword;
using LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeywordWithListKeyword;
using LinhChiDoiSOS.Application.Features.Keywords.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        [Route("list-keyword")]
        public async Task<List<CategoryKeywordWithListKeyword>> GetCategoryKeywordByListKeyword()
        {
            try {
                var response = await _mediator.Send(new GetCategoryKeywordWithListKeywordQuery());
                return response;
            }
            catch (Exception ex) {
                // Log the exception and return an appropriate response.
                throw new BadRequestException("Error at category");
            }
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
