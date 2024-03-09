using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetAllCourseDetail
{
    public class GetAllCourseDetailQuery : IRequest<List<CourseDetailResponse>>
    {
    }
}
