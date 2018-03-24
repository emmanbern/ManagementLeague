using LeagueAppManagement.Areas.Admins.Models;
using LeagueAppManagement.Models;
using System.Linq;
using System.Web.Mvc;

namespace LeagueAppManagement.Areas.Admins.Controllers
{
    public class ManageTeamController : Controller
    {
        ApplicationDbContext _dbContext;

        public ManageTeamController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult List()
        {
            var players = _dbContext.Players.Select(s => new PlayerViewModel
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                GradeEnum = s.Grade,
                PhoneNumber = s.PhoneNumber,
                Guid = s.Guid,
                PositionEnum = s.Position
            }).ToList();

            return View(players);
        }

    }
}