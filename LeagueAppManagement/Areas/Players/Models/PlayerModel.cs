﻿using LeagueAppManagement.Data;

namespace LeagueAppManagement.Areas.Players.Models
{
    public class PlayerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public GradeEnum Grade { get; set; }
    }
}