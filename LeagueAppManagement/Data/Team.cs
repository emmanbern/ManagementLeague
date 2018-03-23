using System.Collections.Generic;

namespace LeagueAppManagement.Data
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}