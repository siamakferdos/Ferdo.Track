using Microsoft.AspNetCore.Mvc;

namespace Ferdo.Track.Areas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/UnderTrack")]
    public class UnderTrackApiController : Controller
    {        
        //// GET: api/UnderTrack/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        // POST: api/UnderTrack
        [HttpPost]
        public void AddPoint([FromBody]string value)
        {
        }
        
        // PUT: api/UnderTrack/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
