using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Queries.GetAllCategoryKeyword
{
    public class GetAllCategoryKeywordQuery : IRequest<List<CategoryKeywordResponse>>
    {
    }

}
