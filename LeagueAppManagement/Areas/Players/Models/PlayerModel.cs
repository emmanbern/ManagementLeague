using LeagueAppManagement.Data;
using System;

namespace LeagueAppManagement.Areas.Players.Models
{
    public class PlayerModel
    {
        public Guid? Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public GradeEnum Grade { get; set; }
        public PositionEnum Position { get; set; }
    }
}