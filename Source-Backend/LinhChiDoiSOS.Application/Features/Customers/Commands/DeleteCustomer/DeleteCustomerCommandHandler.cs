using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Customers.Commands.DeleteCustomer;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, SOSResponse>
{
    private ILinhChiDoiSOSDbContext _dbContext { get; set; }
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IMapper _mapper;

    public DeleteCustomerCommandHandler(ILinhChiDoiSOSDbContext dbContext, 
        UserManager<ApplicationUser> userManager, 
        RoleManager<IdentityRole> roleManager,
        SignInManager<ApplicationUser> signInManager,
        IMapper mapper)
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _mapper = mapper;
    }

    public async Task<SOSResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        var userExist = await _userManager.FindByIdAsync(request.ApplicationUserId);
        var customerExist = await _dbContext.Customer
            .Where(c => c.ApplicationUserId == request.ApplicationUserId && !c.IsDelete)
            .SingleOrDefaultAsync();
        if (userExist == null || customerExist == null) {
            throw new NotFoundException("Account doesn't exist!");
        }
        userExist.EmailConfirmed = true;
        customerExist.IsDelete = true;
        
        _dbContext.ApplicationUsers.Update(userExist);
        _dbContext.Customer.Update(customerExist);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new SOSResponse
        {
            Message = "Delete Susccessfully"
        };
    }
}
