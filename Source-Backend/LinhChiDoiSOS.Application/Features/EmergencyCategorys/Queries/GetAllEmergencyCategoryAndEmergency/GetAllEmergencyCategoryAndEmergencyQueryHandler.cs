using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategoryAndEmergency
{
    public class GetAllEmergencyCategoryAndEmergencyQueryHandler : IRequestHandler<GetAllEmergencyCategoryAndEmergencyQuery, List<EmergencyCategoryAndEmergencyModel>>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public GetAllEmergencyCategoryAndEmergencyQueryHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<EmergencyCategoryAndEmergencyModel>> Handle(GetAllEmergencyCategoryAndEmergencyQuery request, CancellationToken cancellationToken)
        {
            var listCate = _dbContext.EmergencyCategory.Where(x => !x.IsDelete).OrderBy(x => x.PriorityLevel).ToList();

            var listResult = new List<EmergencyCategoryAndEmergencyModel>();
            foreach (var item in listCate)
            {
                var listEmergency = _dbContext.Emergency.Where(x => x.EmergencyCategoryId == item.Id && !x.IsDelete).ToList();
                var listEmerModel = new List<EmergencyModel>();
                foreach (var itemE in listEmergency)
                {
                    var model = new EmergencyModel()
                    {
                        EmergencyId = itemE.Id,
                        Image = itemE.Image,
                        Title = itemE.Title,
                    };
                    listEmerModel.Add(model);
                }
                var result = new EmergencyCategoryAndEmergencyModel
                {
                    EmergencyCategoryId = item.Id,
                    EmergencyModels = listEmerModel,
                    Description = item.Description,
                    Name = item.Name,
                };
                listResult.Add(result);
            }
            return Task.FromResult(listResult);
        }
    }
}
