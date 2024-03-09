using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.VEmergencyDetails.Queries.GetEmergencyDetailsByEmergencyId
{
    public class GetEmergencyDetailsByEmergencyIdQueryHandler : IRequestHandler<GetEmergencyDetailsByEmergencyIdQuery, List<EmergencyDetailModel>>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public GetEmergencyDetailsByEmergencyIdQueryHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EmergencyDetailModel>> Handle(GetEmergencyDetailsByEmergencyIdQuery request, CancellationToken cancellationToken)
        {
            //List Result 
            var listResult = new List<EmergencyDetailModel>();

            //Get List EmergencyDetail
            var emergencyDetail = _dbContext.EmergencyDetail.Where(x => x.EmergencyId == request.EmergencyId && !x.IsDelete).OrderBy(x => x.Step).ToList();

            //Kiểm tra từng Detail để kiếm mini content và answer content coi có không ?
            foreach (var item in emergencyDetail)
            {
                //Kiểm tra minicontent
                var minicontent = new List<MiniContentModelOfED>();
                var listMiniContents = await _dbContext.MiniContent.Where(x => x.EmergencyDetailId == item.Id && !x.IsDelete).ToListAsync();
                if (listMiniContents.Any())
                {
                    foreach (var mc in listMiniContents)
                    {
                        var temp = new MiniContentModelOfED()
                        {
                            Content = mc.Content,
                            ContentUrl = mc.ContentUrl,
                            EmergencyDetailId = mc.EmergencyDetailId
                        };
                        minicontent.Add(temp);
                    }
                }
                //Kiểm tra answercontent 
                var anwsercontent = new List<AnswerContentModelOfED>();
                var listAnswerContents = await _dbContext.AnswerContents.Where(x => x.EmergencyDetailId == item.Id && !x.IsDelete).ToListAsync();
                if(listAnswerContents.Any())
                {
                    foreach(var ac in listAnswerContents)
                    {
                        var temp = new AnswerContentModelOfED()
                        {
                            Answer = ac.Answer,
                            EmergencyDetailId = ac.EmergencyDetailId,
                            NextStepAfterAnswer = ac.NextStepAfterAnswer,
                        };
                        anwsercontent.Add(temp);
                    }
                }
                var detail = new EmergencyDetailModel()
                {
                    ActionContent = item.ActionContent,
                    AnswerContentModelOfEDs = anwsercontent,
                    ContentBottom = item.ContentBottom,
                    ContentLeft = item.ContentLeft,
                    ContentLeftUrl = item.ContentLeftUrl,
                    ContentRight = item.ContentRight,
                    ContentRightUrl = item.ContentRightUrl,
                    EmergencyId = item.EmergencyId,
                    IsSafe = item.IsSafe,
                    MainPictureUrl = item.MainPictureUrl,
                    MiniContentModelOfEDs = minicontent,
                    Step = item.Step,
                    TopContent = item.TopContent,
                };
                listResult.Add(detail);
            }
            return listResult;
        }
    }
}
