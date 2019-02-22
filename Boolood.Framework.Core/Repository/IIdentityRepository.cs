using Common.ApplicationIdentity;
using Microsoft.AspNetCore.Identity;

namespace Ferdo.Track.Framework.Core.Repository
{
    public interface IIdentityRepository
    {
        void AddRole(ApplicationRole role);
        IdentityResult AddUser(ApplicationUser user, string password);
        void AddToRole(ApplicationUser user, string role);
        bool IsRoleExist(string roleName);
        bool IsUserExist(string email);
    }
}
