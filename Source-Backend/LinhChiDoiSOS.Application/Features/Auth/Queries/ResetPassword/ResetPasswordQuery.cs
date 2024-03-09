using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Auth.Queries.ResetPassword
{
    public class ResetPasswordQuery : IRequest<string>
    {
        public string Email { get; set; }
    }
}


