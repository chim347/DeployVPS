using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Courses.Queries.GetAllCourse
{
    public class GetAllCourseQuery : IRequest<List<CategoryResponse>>
    {
    }
}
