using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.Bookings.Queries
{
    public class TotalBooked
    {
        public int QuantityAccountBooked { get; set; }
        public double? TotalPriceBooked { get; set; }
        public List<CustomerBooked> ListCustomerBookInThisTime { get; set; }
    }
    public class CustomerBooked
    {
        public Guid CustomerId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public int IsPremium { get; set; }
        public string? DateBooked { get; set; }
        public double? Price { get; set; }
    }
    public class GetCustomerBookedCommand : IRequest<TotalBooked>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class GetCustomerBookedCommandHandler : IRequestHandler<GetCustomerBookedCommand, TotalBooked>
    {
        private readonly ILinhChiDoiSOSDbContext _dbConext;
        private readonly UserManager<ApplicationUser> _userManager;

        public GetCustomerBookedCommandHandler(ILinhChiDoiSOSDbContext dbConext, UserManager<ApplicationUser> userManager)
        {
            _dbConext = dbConext;
            _userManager = userManager;
        }

        public async Task<TotalBooked> Handle(GetCustomerBookedCommand request, CancellationToken cancellationToken)
        {
            var result = new TotalBooked();
            result.ListCustomerBookInThisTime = new List<CustomerBooked>();
            var listBookInRangeTime = await _dbConext.Booking.Where(x => x.Created >= request.StartDate && x.Created <= request.EndDate).OrderByDescending(x => x.Created).ToListAsync();
            if (listBookInRangeTime.Any())
            {
                result.TotalPriceBooked = listBookInRangeTime.Sum(x => x.Price);
                result.QuantityAccountBooked = listBookInRangeTime.Count();
                foreach (var item in listBookInRangeTime)
                {
                    // Lấy cus dựa vào booking có chứa cusid
                    var customer =await _dbConext.Customer.Where(x => x.Id == item.CustomerId).FirstAsync();
                    var applicationUser = await _userManager.FindByIdAsync(customer.ApplicationUserId);
                    var cusBookInThisTime = new CustomerBooked
                    {
                        ApplicationUserId = Guid.Parse(applicationUser!.Id),
                        CustomerId = customer.Id,
                        DateBooked = item.Created.ToString("dd/MM/yyyy"),
                        IsPremium = customer.IsPremium,
                        Price = item.Price,
                    };
                    result.ListCustomerBookInThisTime.Add(cusBookInThisTime);
                }
            }
            return result;
        }
    }
}
