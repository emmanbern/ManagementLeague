using LeagueAppManagement.Areas.Admins.Models;
using LeagueAppManagement.Areas.Teams.Models;
using LeagueAppManagement.Data;
using LeagueAppManagement.Models;
using LeagueAppManagement.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LeagueAppManagement.Areas.Teams.Api
{
    public class TeamController : ApiController
    {
        private TeamCreator _creationService;
        private ApplicationDbContext _dbContext;

        public TeamController()
        {
            _creationService = new TeamCreator();
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateTeams(CreateTeamModel model)
        {
            var players = _dbContext.Players
                .Where(w => model.Guids.Contains(w.Guid))
                .ToList();

            var teams = _creationService.CreateTeams(players, new List<Team> { new Team { Name = "Blanc" }, new Team { Name = "Orange" } });

            var viewModel = teams.Select(s => new TeamViewModel
            {
                Guid = s.Guid,
                Name = s.Name,
                Players = s.Players.Select(p => new PlayerViewModel
                {
                    FirstName = p.FirstName,
                    Guid = p.Guid,
                    GradeEnum = p.Grade,
                    LastName = p.LastName,
                    PositionEnum = p.Position,
                    PhoneNumber = p.PhoneNumber
                }).ToList()
            }).ToList();

            return Ok(viewModel);
        }
    }
}