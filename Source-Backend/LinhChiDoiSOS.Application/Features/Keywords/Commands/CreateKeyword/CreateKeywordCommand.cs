using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Keywords.Commands.CreateKeyword
{
    public class CreateKeywordCommand : IRequest<SOSResponse>
    {
        public string? NameKeyword { get; set; }
        public string? DescriptionKeyword { get; set; }

        public Guid CategoryKeywordId { get; set; }

    }

    public class CreateKeywordCommandHandler : IRequestHandler<CreateKeywordCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public CreateKeywordCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SOSResponse> Handle(CreateKeywordCommand request, CancellationToken cancellationToken)
        {
            var categoryKeywordExist = await _dbContext.CategoryKeyword.Where(k => k.Id == request.CategoryKeywordId).SingleOrDefaultAsync();
            if (categoryKeywordExist == null) {
                throw new NotFoundException($"CategoryKeyword is not found {request.CategoryKeywordId}");
            }
            var keyword = new Keyword
            {
                Name = request.NameKeyword,
                Description = request.DescriptionKeyword,
                CategoryKeywordId = request.CategoryKeywordId
            };

            _dbContext.Keyword.Add(keyword);
            await _dbContext.SaveChangesAsync();

            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
