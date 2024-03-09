using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinhChiDoiSOS.Application.Features.ComboCourses.Commands.CreateComboCourse
{
    public class CreateComboCourseCommand : IRequest<SOSResponse>
    {
        public string NameCombo {  get; set; }
    }

    public class CreateComboCourseCommandHandler : IRequestHandler<CreateComboCourseCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public CreateComboCourseCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SOSResponse> Handle(CreateComboCourseCommand request, CancellationToken cancellationToken)
        {
            var comboCourse = new ComboCourse
            {
                Name = request.NameCombo
            };
            _dbContext.ComboCourse.Add(comboCourse);
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
