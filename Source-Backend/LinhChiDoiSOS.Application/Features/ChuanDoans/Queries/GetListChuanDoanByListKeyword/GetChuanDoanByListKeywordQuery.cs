using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetListChuanDoanByKeyword
{
    public class GetChuanDoanByListKeywordQuery : IRequest<List<ChuanDoanByListKeywordResponse>>
    {
        public List<KeywordIdsList> KeywordListData { get; set; }
    }
    public class KeywordIdsList
    {
        public string KeywordId { get; set; }
    }

    public class GetChuanDoanByListKeywordQueryHandler : IRequestHandler<GetChuanDoanByListKeywordQuery, List<ChuanDoanByListKeywordResponse>>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public readonly IMapper _mapper;
        public GetChuanDoanByListKeywordQueryHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ChuanDoanByListKeywordResponse>> Handle(GetChuanDoanByListKeywordQuery request, CancellationToken cancellationToken)
        {
            var keywordIds = request.KeywordListData.Select(kw => Guid.Parse(kw.KeywordId)).ToList();
            var chuanDoanListKeyword = new List<ChuanDoanByListKeywordResponse>();

            // sài HashSet để lưu Id
            var seenIds = new HashSet<Guid>();

            foreach (var keywordId in keywordIds) {
                var listChuanDoan_keyword = await _dbContext.ChuanDoan_Keyword
                    .Where(cdk => cdk.KeywordId == keywordId).ToListAsync();
                foreach(var chuanDoan_keyword in listChuanDoan_keyword) {

                    // check Id xuất hiện chưa
                    if (!seenIds.Contains(chuanDoan_keyword.ChuanDoanId)) {
                        var chuanDoan = _dbContext.ChuanDoan
                            .Where(c => c.Id == chuanDoan_keyword.ChuanDoanId && !c.IsDelete)
                            .SingleOrDefault();

                        // add Id vào HashSet
                        seenIds.Add(chuanDoan.Id);

                        var chuanDoanListKeywordResponse = new ChuanDoanByListKeywordResponse
                        {
                            Id = chuanDoan.Id,
                            Name = chuanDoan.Name,
                            Description = chuanDoan.Description,
                            UrlImage = chuanDoan.UrlImage,
                            KeywordListData = ListKeywordData(chuanDoan.Id)
                        };
                        chuanDoanListKeyword.Add(chuanDoanListKeywordResponse);
                    }
                }
            }
            return chuanDoanListKeyword;
        }
        private List<KeywordData> ListKeywordData(Guid chuanDoanId)
        {
            var keywordId = _dbContext.ChuanDoan_Keyword
                        .Where(cdk => cdk.ChuanDoanId == chuanDoanId)
                        .Select(k => k.KeywordId)
                        .ToList();
            var listKeywordData = new List<KeywordData>();
            foreach(var keyword in keywordId) {
                var keywordObject = _dbContext.Keyword.Where(k => k.Id == keyword).SingleOrDefault();
                var keywordData = new KeywordData
                {
                    Id = keywordObject.Id,
                    Name = keywordObject.Name,
                };
                listKeywordData.Add(keywordData);
            }
            return listKeywordData;
        }
    }


}
