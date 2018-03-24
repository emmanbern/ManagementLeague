using LeagueAppManagement.Areas.Players.Models;
using LeagueAppManagement.Data;
using LeagueAppManagement.Models;
using System;
using System.Linq;
using System.Web.Http;

namespace LeagueAppManagement.Areas.Players
{
    public class PlayerController : ApiController
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        [HttpPost]
        public IHttpActionResult Create(PlayerModel player)
        {

            _dbContext.Players.Add(new Player
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PhoneNumber = player.PhoneNumber,
                Grade = player.Grade,
                Position = player.Position,
                Guid = Guid.NewGuid()
            });

            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Update(PlayerModel player)
        {
            var dbPlayer = _dbContext.Players.FirstOrDefault(f => f.Guid == player.Guid.Value);

            if (dbPlayer == null)
            {
                return NotFound();
            }

            dbPlayer.FirstName = player.FirstName;
            dbPlayer.LastName = player.LastName;
            dbPlayer.PhoneNumber = dbPlayer.PhoneNumber;
            dbPlayer.Grade = player.Grade;
            dbPlayer.Position = player.Position;

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}