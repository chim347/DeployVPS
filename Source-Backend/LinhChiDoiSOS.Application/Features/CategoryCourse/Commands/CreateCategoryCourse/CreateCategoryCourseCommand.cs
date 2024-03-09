using AutoMapper;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.CategoryCourse.Commands.CreateCategoryCourse
{
    public class CreateCategoryCourseCommand: IRequest<SOSResponse>
    {
        public string? Name {  get; set; }
    }

    public class CreateCategoryCourseCommandHandler : IRequestHandler<CreateCategoryCourseCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public CreateCategoryCourseCommandHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<SOSResponse> Handle(CreateCategoryCourseCommand request, CancellationToken cancellationToken)
        {
            /*var categoryNameExist = await _dbContext.Category
                                        .Where(c => c.Name
                                        .Equals( request.Name, StringComparison.OrdinalIgnoreCase) && !c.IsDelete)
                                        .SingleOrDefaultAsync();*/
            var categoryNameExist = await _dbContext.Category
                                        .Where(c => c.Name == request.Name && !c.IsDelete)
                                        .SingleOrDefaultAsync();
            if (categoryNameExist != null) {
                throw new BadRequestException("Category name is already!!!");
            }
            var category = new Category
            {
                Name = request.Name,
            };
            _dbContext.Category.Add(category);
            await _dbContext.SaveChangesAsync();

            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
