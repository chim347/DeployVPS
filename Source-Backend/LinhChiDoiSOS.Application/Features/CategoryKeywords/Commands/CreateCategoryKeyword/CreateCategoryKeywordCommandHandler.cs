using AutoMapper;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.CategoryKeywords.Commands.CreateCategoryKeyword
{
    public class CreateCategoryKeywordCommandHandler : IRequestHandler<CreateCategoryKeywordCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public CreateCategoryKeywordCommandHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<SOSResponse> Handle(CreateCategoryKeywordCommand request, CancellationToken cancellationToken)
        {
            var categoryNameExist = await _dbContext.CategoryKeyword
                .Where(c => c.Name == request.CategoryName && !c.IsDelete).SingleOrDefaultAsync();

            if (categoryNameExist != null) {
                throw new BadRequestException("already exist!");
            }

            var categoryKeyword = new CategoryKeyword
            {
                Name = request.CategoryName,
                Description = request.Description,
            };
            _dbContext.CategoryKeyword.Add(categoryKeyword);
            await _dbContext.SaveChangesAsync();

            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
