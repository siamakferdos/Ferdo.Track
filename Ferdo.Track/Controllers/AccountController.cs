using Common.ApplicationIdentity;
using Ferdo.Track.Areas.Identity.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ferdo.Track.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> loginManager;
        private readonly RoleManager<ApplicationRole> roleManager;


        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> loginManager,
            RoleManager<ApplicationRole> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                user.FirstName = obj.FirstName;
                user.LastName = obj.LastName;

                IdentityResult result = userManager.CreateAsync
                    (user, obj.Password).Result;

                //if (result.Succeeded)
                //{
                //    if (!roleManager.RoleExistsAsync("NormalUser").Result)
                //    {
                //        var role = new ApplicationRole();
                //        role.Name = "NormalUser";

                //        IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                //        if (!roleResult.Succeeded)
                //        {
                //            ModelState.AddModelError("",
                //                "Error while creating role!");
                //            return View(obj);
                //        }
                //    }

                //    userManager.AddToRoleAsync(user,
                //        "NormalUser").Wait();
                //    return RedirectToAction("Login", "Account");
                //}
            }
            return View(obj);
        }

     
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = loginManager.PasswordSignInAsync
                (obj.UserName, obj.Password,
                    obj.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login!");
            

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            loginManager.SignOutAsync().Wait();
            return RedirectToAction("Login", "Account");
        }
    }
}