using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetAllChuanDoan
{
    public class GetAllChuanDoanQuery : IRequest<List<ChuanDoanResponse>>
    {
    }
}
