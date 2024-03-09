using LinhChiDoiSOS.Domain.Entities;
using LinhChiDoiSOS.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Infrastructure.Persistence
{
    public class LinhChiDoiSOSDbContextInitialiser
    {
        private readonly ILogger<LinhChiDoiSOSDbContextInitialiser> _logger;
        private readonly LinhChiDoiSOSDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public LinhChiDoiSOSDbContextInitialiser(ILogger<LinhChiDoiSOSDbContextInitialiser> logger, 
            LinhChiDoiSOSDbContext dbContext, 
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task InitialiseAsync()
        {
            try {
                if(_dbContext.Database.IsSqlServer()) {
                    await _dbContext.Database.MigrateAsync();
                }
            }catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try {
                await TrySeedAsync();
            }
            catch(Exception ex) {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {
            //Default roles
            var roles = new List<IdentityRole>
            {
                new IdentityRole("Administrator"),
                new IdentityRole("Manager"),
                new IdentityRole("Customer")
            };
            foreach (var role in roles) {
                if (_roleManager.Roles.All(r => r.Name != role.Name)) {
                    await _roleManager.CreateAsync(role);
                }
            }

            // Administror
            var administrator = new ApplicationUser
            {
                UserName = "administrator@localhost",
                Fullname = "Nguyen Ngoc Thai Vi",
                Email = "administrator@localhost",
                Image = "123",

            };

            // Manager
            var manager = new ApplicationUser
            {
                UserName = "manager@localhost",
                Fullname = "Nguyen Thanh Nhan",
                Email = "Manager@localhost",
                Image = "123",

            };

            if (_userManager.Users.All(u => u.UserName != administrator.UserName)) {
                await _userManager.CreateAsync(administrator, "P@ssW0rd1");

                var administratorRole = roles.FirstOrDefault(r => r.Name == "Administrator");
                if (administratorRole != null) {
                    await _userManager.AddToRoleAsync(administrator, administratorRole.Name);
                }
            }

            if (!_dbContext.TodoLists.Any()) {
                _dbContext.TodoLists.Add(new TodoList
                {
                    Title = "Todo List",
                    Items =
            {
                new TodoItem { Title = "Make a todo list 📃" },
                new TodoItem { Title = "Check off the first item ✅" },
                new TodoItem { Title = "Realise you've already done two things on the list! 🤯"},
                new TodoItem { Title = "Reward yourself with a nice, long nap 🏆" },
            }
                });

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
