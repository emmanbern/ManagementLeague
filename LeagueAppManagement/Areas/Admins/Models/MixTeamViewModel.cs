using System.Collections.Generic;

namespace LeagueAppManagement.Areas.Admins.Models
{
    public class MixTeamViewModel
    {
        public IEnumerable<PlayerViewModel> Players { get; set; } = new List<PlayerViewModel>();
    }
}