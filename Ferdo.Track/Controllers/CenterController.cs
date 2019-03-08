using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.ApplicationIdentity;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Model.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ferdo.Track.Controllers
{
    public class CenterController : Controller
    {
        private readonly ICenterService _centerService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CenterController(ICenterService centerService,
            UserManager<ApplicationUser> userManager)
        {
            userManager = userManager;
            _centerService = centerService;
        }

        [Authorize]
        public IActionResult AddCenter(CenterDto centerDto)
        {
            var u = this.User;
            
            _centerService.AddCenter(centerDto);
            return Ok();
        }
    }
}