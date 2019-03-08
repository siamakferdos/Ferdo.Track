using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common.ApplicationIdentity;
using Ferdo.Track.Framework.Core.Query;
using Microsoft.AspNetCore.Mvc;
using Ferdo.Track.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Ferdo.Track.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnderTrackQuery _underTrackQuery;

        public HomeController(UserManager<ApplicationUser>
            userManager, IUnderTrackQuery underTrackQuery)
        {
            _userManager = userManager;
            _underTrackQuery = underTrackQuery;
        }


        [Authorize]
        public IActionResult Index()
        {
            TempData["UnderTrackType"] = _underTrackQuery.GetUnderTrackTypes();
            ApplicationUser user = _userManager.GetUserAsync
                (HttpContext.User).Result;

            ViewBag.Message = $"Welcome {user.FirstName} {user.LastName}!";
            if (_userManager.IsInRoleAsync(user, "NormalUser").Result)
            {
                ViewBag.RoleMessage = "You are a NormalUser.";
            }
            return View();
        }
    }
}
