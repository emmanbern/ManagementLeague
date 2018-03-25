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

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult MixTeam()
        {
            var mixTeamViewModel = new MixTeamViewModel();
            mixTeamViewModel.Players = _dbContext.Players.Select(s => new PlayerViewModel
            {
                FirstName = s.FirstName,
                GradeEnum = s.Grade,
                LastName = s.LastName,
                Guid = s.Guid,
                PhoneNumber = s.PhoneNumber,
                PositionEnum = s.Position
            }).ToList();

            return View(mixTeamViewModel);
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