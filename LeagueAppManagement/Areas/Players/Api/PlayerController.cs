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
        public IHttpActionResult Create()
        {
            _dbContext.Players.Add(new Player
            {
                FirstName = "Emmanuel",
                LastName = "Genest",
                PhoneNumber = "819-888-3344",
                Grade = GradeEnum.A,
            });

            _dbContext.SaveChanges();
            return Ok();
        }
    }
}