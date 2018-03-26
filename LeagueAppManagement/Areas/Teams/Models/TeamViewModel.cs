using LeagueAppManagement.Areas.Admins.Models;
using System;
using System.Collections.Generic;

namespace LeagueAppManagement.Areas.Teams.Models
{
    public class TeamViewModel
    {
        public List<PlayerViewModel> Players { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
    }
}
