using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.VEmergencyDetails.Queries.GetEmergencyDetailsByEmergencyId
{
    public class GetEmergencyDetailsByEmergencyIdQuery : IRequest<List<EmergencyDetailModel>>
    {
        public Guid EmergencyId { get; set; }   
    }
}
