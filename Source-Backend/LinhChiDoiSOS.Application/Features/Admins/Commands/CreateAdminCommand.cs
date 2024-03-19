using AutoMapper;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Admins.Commands
{
    public class CreateAdminCommand : IRequest<SOSResponse>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
    }

    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, SOSResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public CreateAdminCommandHandler(
            ILinhChiDoiSOSDbContext dbContext,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<SOSResponse> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            var emailExist = await _userManager.FindByEmailAsync(request.Email);
            if (emailExist != null)
            {
                throw new BadRequestException("Admin already exists!");
            }

            var user = new ApplicationUser
            {
                UserName = request.UserName,
                Email = request.Email,
                Fullname = request.Fullname,
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = request.Phone,
                EmailConfirmed = false,
                Address = null,
                BirthDay = null,
                Image = "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/avatar%2Fuser132.jpg?alt=media&token=70eb3ce5-4145-4b18-b974-1b741fecba4c",
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Manager");
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            else
            {
                throw new BadRequestException("Account creation failed !");
            }
            var admin = new Admin
            {
                ApplicationUserId = user.Id,
                IsDelete = false,
            };

            await _dbContext.Admin.AddAsync(admin);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
