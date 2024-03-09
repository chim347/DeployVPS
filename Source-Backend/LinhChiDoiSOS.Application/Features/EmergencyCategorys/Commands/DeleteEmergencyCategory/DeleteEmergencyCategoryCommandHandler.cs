using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.DeleteEmergencyCategory
{
    public class DeleteEmergencyCategoryCommandHandler : IRequestHandler<DeleteEmergencyCategoryCommand, SOSResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext;

        public DeleteEmergencyCategoryCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SOSResponse> Handle(DeleteEmergencyCategoryCommand request, CancellationToken cancellationToken)
        {
            var cate = await _dbContext.EmergencyCategory.Where(x => string.Compare(x.Id.ToString(), request.EmergencyCategoryId) == 0).FirstOrDefaultAsync();
            if (cate == null)
            {
                throw new BadRequestException("Category does not exists!");
            }
            //Kiểm tra xem các Emergency có tồn tại không, nếu có thì nó có đang bị
            //delete hay không? Nếu có thì có thể delete được còn nếu chỉ cần có 1 
            //cái chưa bị delete thì không cho xóa
            var checkExistedEmergency = await _dbContext.Emergency.Where(x => x.EmergencyCategoryId == cate.Id &&
                                                                              !x.IsDelete).ToListAsync();
            if (checkExistedEmergency.Any())
            {
                throw new BadRequestException("Category can not be delete because have Emergency!");
            }
            //Ok delete
            _dbContext.EmergencyCategory.Remove(cate);
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Delete Successfully"
            };
        }
    }
}
