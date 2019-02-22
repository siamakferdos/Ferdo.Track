using Microsoft.AspNetCore.Identity;

namespace Common.ApplicationIdentity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
        public string Description { get; set; }
    }
}
