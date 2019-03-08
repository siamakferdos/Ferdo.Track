using System.Collections.Generic;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Model.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Ferdo.Track.Areas.Api.Controllers
{
    [Produces("application/json")]
    [Area("Api")]
    [Route("api/location")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult AddLocation([FromBody]List<LocationDto> locations)
        {
            _locationService.AddLocations(locations);
            return Ok("That's OK");
        }
    }
}
