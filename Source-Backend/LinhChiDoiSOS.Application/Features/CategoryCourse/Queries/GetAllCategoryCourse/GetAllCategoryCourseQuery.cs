using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CategoryCourse.Queries.GetAllCategoryCourse
{
    public class GetAllCategoryCourseQuery : IRequest<List<CategoryCourseResponse>>
    {
    }
}
