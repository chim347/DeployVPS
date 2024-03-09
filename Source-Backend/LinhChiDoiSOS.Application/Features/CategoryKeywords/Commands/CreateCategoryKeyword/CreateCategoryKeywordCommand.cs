using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Commands.CreateCategoryKeyword
{
    public class CreateCategoryKeywordCommand : IRequest<SOSResponse>
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
