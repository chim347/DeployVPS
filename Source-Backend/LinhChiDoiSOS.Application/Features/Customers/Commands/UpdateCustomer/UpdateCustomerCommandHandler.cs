using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Customers.Commands.UpdateCustomer;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, SOSResponse>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILinhChiDoiSOSDbContext _dbContext;
    private readonly IMapper _mapper;
    public UpdateCustomerCommandHandler(ILinhChiDoiSOSDbContext dbContext, 
        IMapper mapper, 
        UserManager<ApplicationUser> userManager)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<SOSResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var userExist = await _userManager.FindByIdAsync(request.ApplicationUserId);
        var customerExist = await _dbContext.Customer.Where(c => c.ApplicationUserId == request.ApplicationUserId).SingleOrDefaultAsync();
        if(userExist == null || customerExist == null) {
            throw new NotFoundException("Customer does not exist!");
        }

        userExist.Fullname = request.FullName;
        userExist.BirthDay = request.BirthDay;
        userExist.Image = request.Image;
        userExist.Address = request.Adress;
        userExist.PhoneNumber = request.Phone;
        _dbContext.ApplicationUsers.Update(userExist);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var user = await _userManager.FindByIdAsync(userExist.Id);
        if(user != null) {
            var userRoles = await _userManager.GetRolesAsync(user);
            // delete role present
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            // add new role
            await _userManager.AddToRoleAsync(user, "Customer");
        }

        return new SOSResponse
        {
            Message = "Update Successfully"
        };
    }
}
