using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common.ApplicationIdentity;
using Microsoft.AspNetCore.Mvc;
using Ferdo.Track.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Ferdo.Track.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(UserManager<ApplicationUser>
            userManager)
        {
            this.userManager = userManager;
        }


        [Authorize]
        public IActionResult Index()
        {
            ApplicationUser user = userManager.GetUserAsync
                (HttpContext.User).Result;

            ViewBag.Message = $"Welcome {user.FirstName} {user.LastName}!";
            if (userManager.IsInRoleAsync(user, "NormalUser").Result)
            {
                ViewBag.RoleMessage = "You are a NormalUser.";
            }
            return View();
        }
    }
}
