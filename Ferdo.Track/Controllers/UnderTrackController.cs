using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferdo.Track.Framework.Core.Query;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ferdo.Track.Controllers
{
    public class UnderTrackController : Controller
    {
        private readonly IUnderTrackQuery _underTrackQuery;
        private IUnderTrackService _underTrackService;

        public UnderTrackController(IUnderTrackQuery underTrackQuery, IUnderTrackService underTrackService)
        {
            _underTrackQuery = underTrackQuery;
            _underTrackService = underTrackService;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult AddGroup(UnderTrackGroupDto underTrackGroupDto)
        {
            _underTrackService.AddGroup(underTrackGroupDto);
            return Ok("ok");
        }

        public IActionResult AddUnderTrack(UnderTrackDto underTrackDto)
        {
            _underTrackService.AddUnderTrack(underTrackDto);
            return Ok("ok");
        }

        public IActionResult UpdateUnderTrackGroupMembers(List<UnderTrackGroupMemberDto> underTrackGroupMemberDtos)
        {
            _underTrackService.UpdateGroupUnderTrackMembers(underTrackGroupMemberDtos);
            return Ok("ok");
        }

        public IActionResult GetGroups()
        {
            if(User.Identities == null || !User.Identities.Any())
                return Redirect("Acount/Login");
            var userName = User.Identities.First().Name;
            var underTrackGroups = _underTrackQuery.GetUnderTrackGroups(userName);
            return Json(JsonConvert.SerializeObject(underTrackGroups));
        }

        private List<UnderTrackTypeDto> GetUnderTrackTypes()
        {
            var types = _underTrackQuery.GetUnderTrackTypes();
            return types;
        }
    }
}