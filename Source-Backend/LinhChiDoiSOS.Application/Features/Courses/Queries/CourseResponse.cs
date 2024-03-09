using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Courses.Queries
{
    public class CategoryResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public List<CourseResponse>? CourseResponses {  get; set; }
    }
}
