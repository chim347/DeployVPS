using AutoMapper;
using AutoMapper.QueryableExtensions;
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

namespace LinhChiDoiSOS.Application.Features.Customers.Queries.GetCustomerByEmail
{
    public class GetCustomerByEmailQuery : IRequest<CustomerResponse>
    {
        public string Email { get; set; }
    }

    public class GetCustomerByEmailQueryHandler : IRequestHandler<GetCustomerByEmailQuery, CustomerResponse>
    {
        private readonly ILinhChiDoiSOSDbContext _dbConext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        public GetCustomerByEmailQueryHandler(ILinhChiDoiSOSDbContext context,
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

        public async Task<CustomerResponse> Handle(GetCustomerByEmailQuery request, CancellationToken cancellationToken)
        {
            var applicationUser = _dbConext.ApplicationUsers.Where(a => a.Email == request.Email);
            var user = applicationUser.SingleOrDefault();
            if (user == null) {
                /*throw new NotFoundException("Not Found");*/
                return new CustomerResponse();
            }
            var customer = _dbConext.Customer.Where(c => c.ApplicationUserId == user.Id);

            var result = new CustomerResponse
            {
                CustomerData = customer.ProjectTo<CustomerData>(_mapper.ConfigurationProvider).SingleOrDefault(),
                ApplicationUserData= applicationUser.ProjectTo<ApplicationCustomer>(_mapper.ConfigurationProvider).SingleOrDefault()
            };
            return result;
        }
    }
}
