using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.VEmergencyDetails.Commands.CreateEmergencyDetails
{
    public class CreateEmergencyDetailsCommandHandler : IRequestHandler<CreateEmergencyDetailsCommand, SOSResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        public Task<SOSResponse> Handle(CreateEmergencyDetailsCommand request, CancellationToken cancellationToken)
        {
            //Check Emergency Existed 
            var emergency = _dbContext.Emergency.Where(x => x.Id == request.EmergencyDetailModel.EmergencyId && !x.IsDelete).FirstOrDefault();
            if(emergency == null)
            {
                throw new NotFoundException("Chưa từng tồn tại emergency nào có Id này");
            }
            var emergencyDetail = new EmergencyDetail
            {
                ActionContent = request.EmergencyDetailModel.ActionContent,
                ContentBottom = request.EmergencyDetailModel.ContentBottom,
                ContentLeft = request.EmergencyDetailModel.ContentLeft,
                ContentLeftUrl = request.EmergencyDetailModel.ContentLeftUrl,
                ContentRight = request.EmergencyDetailModel.ContentRight,
                ContentRightUrl = request.EmergencyDetailModel.ContentRightUrl,
                EmergencyId = request.EmergencyDetailModel.EmergencyId,
                IsSafe = request.EmergencyDetailModel.IsSafe,
                Step = request.EmergencyDetailModel.Step,
                MainPictureUrl = request.EmergencyDetailModel.MainPictureUrl,
                TopContent = request.EmergencyDetailModel.TopContent,
               // ListMiniContent = request.EmergencyDetailModel.MiniContentModelOfEDs
               // ListAnswerContent
            };
            _dbContext.EmergencyDetail.Add(emergencyDetail);

            if(request.EmergencyDetailModel.MiniContentModelOfEDs!= null && request.EmergencyDetailModel.MiniContentModelOfEDs.Any())
            {
                foreach(var item in request.EmergencyDetailModel.MiniContentModelOfEDs)
                {
                    var miniContent = new MiniContent
                    {
                        Content = item.Content,
                        ContentUrl = item.ContentUrl,
                        EmergencyDetailId = emergencyDetail.Id
                    };
                    _dbContext.MiniContent.Add(miniContent);
                }
            }
            if (request.EmergencyDetailModel.AnswerContentModelOfEDs != null && request.EmergencyDetailModel.AnswerContentModelOfEDs.Any())
            {
                foreach (var item in request.EmergencyDetailModel.AnswerContentModelOfEDs)
                {
                    var answerContents = new AnswerContent
                    {
                        NextStepAfterAnswer = item.NextStepAfterAnswer,
                        Answer = item.Answer,
                        EmergencyDetailId = emergencyDetail.Id
                    };
                    _dbContext.AnswerContents.Add(answerContents);
                }
            }


            throw new NotImplementedException();
        }
    }
}
