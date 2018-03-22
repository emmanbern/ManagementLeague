using LeagueAppManagement.Areas.Players.Models;
using LeagueAppManagement.Data;
using LeagueAppManagement.Models;
using System.Web.Http;

namespace LeagueAppManagement.Areas.Players
{
    public class PlayerController : ApiController
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

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

        [HttpPost]
        public IHttpActionResult Create(PlayerModel player)
        {

            _dbContext.Players.Add(new Player
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PhoneNumber = player.PhoneNumber,
                Grade = player.Grade,
            });

            _dbContext.SaveChanges();
            return Ok();
        }
    }
}