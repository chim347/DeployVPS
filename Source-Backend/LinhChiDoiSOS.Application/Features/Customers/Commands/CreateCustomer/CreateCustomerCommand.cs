using LinhChiDoiSOS.Application.Common.Response;
using MediatR;

namespace LinhChiDoiSOS.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<SOSResponse>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Fullname { get; set; }
        public string? Phone { get; set; }

    }
}
