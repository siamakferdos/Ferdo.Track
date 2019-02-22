using System.Linq;
using Common.ApplicationIdentity;
using Ferdo.Track.Framework.Core.Repository;
using Microsoft.AspNetCore.Identity;

namespace Ferdo.Track.Infrastructure
{
    public class IdentityRepository: IIdentityRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public IdentityRepository(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void AddRole(ApplicationRole role)=>
             _roleManager.CreateAsync(role);
       
        public IdentityResult AddUser(ApplicationUser user, string password) =>
            _userManager.CreateAsync(user, password).Result;

        public void AddToRole(ApplicationUser user, string roleName)
        {
            _userManager.AddToRoleAsync(user,
                roleName).Wait();
        }

        public bool IsRoleExist(string roleName)=> 
            _roleManager.RoleExistsAsync(roleName).Result;

        public bool IsUserExist(string email)
        {
            var result = _userManager.FindByEmailAsync(email).Result;
            return result != null;
        }
    }
}
