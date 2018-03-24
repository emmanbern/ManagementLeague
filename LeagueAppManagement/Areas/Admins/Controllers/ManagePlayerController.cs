using LeagueAppManagement.Areas.Admins.Models;
using LeagueAppManagement.Models;
using System;
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
                PhoneNumber = s.PhoneNumber,
                Guid = s.Guid,
                PositionEnum = s.Position
            }).ToList();

            return View(players);
        }

        public ActionResult Edit(Guid? id)
        {
            var player = _dbContext.Players.Where(f => f.Guid == id).Select(s => new PlayerViewModel
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                PhoneNumber = s.PhoneNumber,
                GradeEnum = s.Grade,
                Guid = s.Guid,
                PositionEnum = s.Position
            }).FirstOrDefault();

            return View(player ?? new PlayerViewModel());
        }

    }
}