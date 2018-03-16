using LeagueAppManagement.Areas.Admins.Models;
using LeagueAppManagement.Models;
using System.Linq;
using System.Web.Mvc;

namespace LeagueAppManagement.Areas.Admins.Controllers
{
    public class ManagePlayerController : Controller
    {
        ApplicationDbContext _dbContext;

        public ManagePlayerController()
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
                PhoneNumber = s.PhoneNumber
            }).ToList();

            return View(players);
        }

        public ActionResult Edit()
        {
            return View();
        }

    }
}