using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.Bookings.Queries
{
    public class CustomerWaitingForPremium
    {
        public Guid CustomerId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public int IsPremium { get; set; }
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Image { get; set; }
        public string? PhoneNumber { get; set; }
    }
    public class GetBookingWaitingCheckCommand : IRequest<List<CustomerWaitingForPremium>>
    {
    }
    public class GetBookingWaitingCheckCommandHandler : IRequestHandler<GetBookingWaitingCheckCommand, List<CustomerWaitingForPremium>>
    {
        private readonly ILinhChiDoiSOSDbContext _dbConext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public GetBookingWaitingCheckCommandHandler(ILinhChiDoiSOSDbContext dbConext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IMapper mapper)
        {
            _dbConext = dbConext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<List<CustomerWaitingForPremium>> Handle(GetBookingWaitingCheckCommand request, CancellationToken cancellationToken)
        {
            var listResult = new List<CustomerWaitingForPremium>();
            var listUser = await _dbConext.Customer.Where(x => x.IsPremium == 1).ToListAsync();
            if (listUser.Any())
            {
                foreach (var user in listUser)
                {
                    var applicationUser = await _userManager.FindByIdAsync(user.ApplicationUserId);
                    var result = new CustomerWaitingForPremium
                    {
                        Address = applicationUser!.Address,
                        ApplicationUserId = Guid.Parse(user.ApplicationUserId),
                        BirthDay = applicationUser!.BirthDay,
                        CustomerId = user.Id,
                        Fullname = applicationUser!.Fullname,
                        Image = applicationUser!.Image,
                        IsPremium = user.IsPremium,
                        PhoneNumber = applicationUser!.PhoneNumber
                    };
                    listResult.Add(result);
                }
            }
            return listResult;
        }
    }

}
