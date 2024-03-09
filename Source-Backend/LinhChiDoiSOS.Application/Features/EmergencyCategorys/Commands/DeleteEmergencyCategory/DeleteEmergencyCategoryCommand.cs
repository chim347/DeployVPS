using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.DeleteEmergencyCategory
{
    public class DeleteEmergencyCategoryCommand : IRequest<SOSResponse>
    {
        public string EmergencyCategoryId { get; set; } = null!;
    }
}
