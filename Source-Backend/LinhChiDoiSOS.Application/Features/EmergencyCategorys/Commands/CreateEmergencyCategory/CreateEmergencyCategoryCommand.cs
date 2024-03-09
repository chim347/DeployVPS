using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.CreateEmergencyCategory
{
    public class CreateEmergencyCategoryCommand : IRequest<SOSResponse>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
