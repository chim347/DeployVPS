using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategory
{
    public class GetAllEmergencyCategoryQueryHandler : IRequestHandler<GetAllEmergencyCategoryQuery, List<EmergencyCategoryModel>>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public GetAllEmergencyCategoryQueryHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<EmergencyCategoryModel>> Handle(GetAllEmergencyCategoryQuery request, CancellationToken cancellationToken)
        {
            var listEC = _dbContext.EmergencyCategory.Where(x => !x.IsDelete).ToList();
            var listResult = new List<EmergencyCategoryModel>();
            foreach(var item in listEC)
            {
                var result = new EmergencyCategoryModel
                {
                    Name = item.Name,
                    Description = item.Description,
                    EmergencyCategoryId = item.Id
                };
                listResult.Add(result);
            }
            return Task.FromResult(listResult);
        }
    }
}
