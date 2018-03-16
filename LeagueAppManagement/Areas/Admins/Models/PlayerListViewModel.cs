using System.Collections.Generic;

namespace LeagueAppManagement.Areas.Admins.Models
{
    public class PlayerListViewModel
    {
        public IEnumerable<PlayerViewModel> Players { get; set; }
    }
}