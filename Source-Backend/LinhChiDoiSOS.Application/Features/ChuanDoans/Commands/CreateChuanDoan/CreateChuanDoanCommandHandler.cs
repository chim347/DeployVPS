using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Commands.CreateChuanDoan
{
    public class CreateChuanDoanCommandHandler : IRequestHandler<CreateChuanDoanCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public CreateChuanDoanCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SOSResponse> Handle(CreateChuanDoanCommand request, CancellationToken cancellationToken)
        {
            // keyword
            var keywordIds = request.KeywordData.Select(k => k.KeywordId).ToList();
            var keywordListExist = await _dbContext.Keyword.Where(k => keywordIds.Contains(k.Id) && !k.IsDelete).ToListAsync();
            //chuan doan
            var chuanDoanExist = await _dbContext.ChuanDoan.Where(c => c.Name == request.ChuanDoanName && !c.IsDelete).SingleOrDefaultAsync();
            if (chuanDoanExist != null) {
                throw new BadRequestException("ChuanDoan already exist!!!");
            }

            foreach (var keyword in keywordListExist) {
                var chuanDoan = new ChuanDoan
                {
                    Name = request.ChuanDoanName,
                    Description = request.Description,
                };
                _dbContext.ChuanDoan.Add(chuanDoan);
            }

            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
