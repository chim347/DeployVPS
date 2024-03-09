using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategoryAndEmergency
{
    public class GetAllEmergencyCategoryAndEmergencyQuery : IRequest<List<EmergencyCategoryAndEmergencyModel>>
    {
    }
}
