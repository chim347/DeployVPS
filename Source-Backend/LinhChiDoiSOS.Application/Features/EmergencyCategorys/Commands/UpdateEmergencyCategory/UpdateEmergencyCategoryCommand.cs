using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.UpdateEmergencyCategory
{
    public class UpdateEmergencyCategoryCommand : IRequest<SOSResponse>
    {
        public Guid EmergenceId { get;set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
