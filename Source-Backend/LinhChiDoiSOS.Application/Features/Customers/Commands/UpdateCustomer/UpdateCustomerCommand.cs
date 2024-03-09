using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<SOSResponse>
    {
        public string ApplicationUserId {  get; set; }

        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Image { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
    }
}
