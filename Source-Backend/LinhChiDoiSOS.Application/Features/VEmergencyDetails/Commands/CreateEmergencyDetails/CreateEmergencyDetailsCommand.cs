using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.VEmergencyDetails.Commands.CreateEmergencyDetails
{
    public class CreateEmergencyDetailsCommand : IRequest<SOSResponse>
    {
        public EmergencyDetailModel EmergencyDetailModel { get; set; } = null!;
    }
}
