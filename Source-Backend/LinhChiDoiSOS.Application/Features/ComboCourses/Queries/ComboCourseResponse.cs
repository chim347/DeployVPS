using LinhChiDoiSOS.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ComboCourses.Queries
{
    public class ComboCourseResponse : IMapFrom<ComboCourse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
