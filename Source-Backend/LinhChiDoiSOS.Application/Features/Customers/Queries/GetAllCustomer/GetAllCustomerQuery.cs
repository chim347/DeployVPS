using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Customers.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery : IRequest<List<CustomerResponse>>
    {
    }
}
