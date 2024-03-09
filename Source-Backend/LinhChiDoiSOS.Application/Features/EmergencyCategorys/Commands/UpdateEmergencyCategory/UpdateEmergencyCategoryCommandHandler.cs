using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.UpdateEmergencyCategory
{
    public class UpdateEmergencyCategoryCommandHandler : IRequestHandler<UpdateEmergencyCategoryCommand, SOSResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public UpdateEmergencyCategoryCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SOSResponse> Handle(UpdateEmergencyCategoryCommand request, CancellationToken cancellationToken)
        {
            var eC = _dbContext.EmergencyCategory.Where(x => x.Id == request.EmergenceId &&
                                                             !x.IsDelete).FirstOrDefault();
            if (eC == null)
            {
                throw new NotFoundException("Customer does not exist!");
            }
            eC.Description = request.Description;
            eC.Name = request.Name;
            _dbContext.EmergencyCategory.Update(eC);
            await _dbContext.SaveChangesAsync();

            return new SOSResponse
            {
                Message = "Update successfully!"
            };
        }
    }
}
