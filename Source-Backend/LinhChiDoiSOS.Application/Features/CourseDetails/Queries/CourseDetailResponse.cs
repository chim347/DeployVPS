using LinhChiDoiSOS.Application.Common.Mappings;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CourseDetails.Queries
{
    public class CourseDetailResponse : IMapFrom<CourseDetail>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }

        public List<StepCourseDetail> StepCourseDetailList { get; set; }

        public string? Conlusion { get; set; }

        public Guid CourseId { get; set; }
        public CourseResponse CourseData { get; set; } = null!;
    }

    public class CourseResponse : IMapFrom<Course>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }

        public Guid CategoryId { get; set; }
        public Guid ComboCourseId { get; set; }
    }

}
