using AutoMapper;
using LinhChiDoiSOS.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CategoryCourse.Queries
{
    public class CategoryCourseResponse : IMapFrom<Category>
    {
        public Guid Id { get; set; }
        public string? Name {  get; set; }
        public DateTime Created {  get; set; }
    }
}
