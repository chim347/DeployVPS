using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Commands.CreateChuanDoan
{
    public class CreateChuanDoanCommand : IRequest<SOSResponse>
    {
        public string? ChuanDoanName { get; set; }
        public string? Description { get; set; }

        public List<KeywordList>? KeywordData {  get; init; }
    }
}

