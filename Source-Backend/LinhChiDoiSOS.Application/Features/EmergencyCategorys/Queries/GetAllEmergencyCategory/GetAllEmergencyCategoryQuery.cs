using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategory
{
    public class GetAllEmergencyCategoryQuery : IRequest<List<EmergencyCategoryModel>>
    {
    }
}
