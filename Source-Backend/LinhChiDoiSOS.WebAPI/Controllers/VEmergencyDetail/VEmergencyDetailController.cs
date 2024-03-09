using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategoryAndEmergency;
using LinhChiDoiSOS.Application.Features.VEmergencyDetails.Queries.GetEmergencyDetailsByEmergencyId;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.API.Controllers.VEmergencyDetail
{
    [Route("api/v1/emergencycategorys")]
    public class VEmergencyDetailController : ControllerBase
    {
        private IMediator _mediator;

        public VEmergencyDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("{emergencyid}")]
        public Task<List<EmergencyDetailModel>> GetAll(Guid emergencyid)
        {
            return _mediator.Send(new GetEmergencyDetailsByEmergencyIdQuery()
            {
                EmergencyId = emergencyid
            });
        }
    }
}
