using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Customers.Queries.GetCustomerByApplicationUserId
{
    public class GetByIdQuery : IRequest<CustomerResponse>
    {
        public string ApplicationUserId {  get; set; } 
    }

    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, CustomerResponse>
    {
        private readonly ILinhChiDoiSOSDbContext _dbConext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        public GetByIdQueryHandler(ILinhChiDoiSOSDbContext context,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _dbConext = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<CustomerResponse> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var customerExist = await _dbConext.Customer.Where(c => c.ApplicationUserId == request.ApplicationUserId).SingleOrDefaultAsync();
            var applicationUser = await _userManager.FindByIdAsync(request.ApplicationUserId);

            var response = new CustomerResponse
            {
                CustomerData = _mapper.Map<CustomerData>(customerExist),
                ApplicationUserData = _mapper.Map<ApplicationCustomer>(applicationUser)
            };

            return response;
        }
    }
}
