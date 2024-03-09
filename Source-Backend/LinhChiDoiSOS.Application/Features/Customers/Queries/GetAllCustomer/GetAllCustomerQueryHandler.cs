using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Customers.Queries;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetAllCustomer;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<CustomerResponse>>
{
    private readonly ILinhChiDoiSOSDbContext _dbConext;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IMapper _mapper;
    public GetAllCustomerQueryHandler(ILinhChiDoiSOSDbContext context, 
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
    public async Task<List<CustomerResponse>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        var customerList = await _dbConext.Customer.Where(c => !c.IsDelete)
            .ProjectTo<CustomerData>(_mapper.ConfigurationProvider)
            .ToListAsync();

        var listResult = new List<CustomerResponse>();
        foreach (var customer in customerList) {
            var customerInfo = await _userManager.FindByIdAsync(customer.ApplicationUserId);
            var customerInfo1 = await _dbConext.ApplicationUsers.Where(a => a.Id == customer.ApplicationUserId)
                .ProjectTo<ApplicationCustomer>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
            //var customerData = _mapper.Map<CustomerData>(customer);
            //var applcationUserData = _mapper.Map<ApplicationCustomer>(customerInfo);
            var result = new CustomerResponse
            {
                CustomerData = customer,
                ApplicationUserData = customerInfo1
            };
            listResult.Add(result);
        }

        return listResult;
    }
}
