using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.CreateEmergencyCategory
{
    public class CreateEmergencyCategoryCommandHandler : IRequestHandler<CreateEmergencyCategoryCommand, SOSResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public CreateEmergencyCategoryCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<SOSResponse> Handle(CreateEmergencyCategoryCommand request, CancellationToken cancellationToken)
        {
            var checkExisted = _dbContext.EmergencyCategory.Where(x => string.Compare(x.Name, request.Name) == 0 && x.IsDelete).FirstOrDefault();
            if (checkExisted != null)
            {
                throw new BadRequestException("Emergency Category đã tồn tại");
            }
            var newCategory = new EmergencyCategory
            {
                Name = request.Name,
                Description = request.Description
            };
            _dbContext.EmergencyCategory.Add(newCategory);
            _dbContext.SaveChangesAsync();

            return Task.FromResult(new SOSResponse
            {
                Message = "Create Successfully!"
            });
        }
    }
}
