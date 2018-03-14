using System.Web.Http;

namespace LeagueAppManagement.Areas.Admins.Api
{
    public class PlayerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetValue()
        {
            return Ok(new { info = "Test" });
        }

        [HttpPost]
        public IHttpActionResult GetOtherValue()
        {
            return Ok(new { info = "Test2" });
        }

        public IHttpActionResult CreatePlayer()
        {
            return Ok();
        }
    }
}
