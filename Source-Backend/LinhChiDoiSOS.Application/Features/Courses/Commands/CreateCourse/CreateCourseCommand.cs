using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<SOSResponse>
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public string CategoryId { get; set; }
        public string ComboCourseId { get; set; }
    }

    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public CreateCourseCommandHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<SOSResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                Name = request.Name,
                Image = request.Image,
                CategoryId = Guid.Parse(request.CategoryId),
                ComboCourseId = Guid.Parse(request.ComboCourseId)
            };
            _dbContext.Course.Add(course);
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
