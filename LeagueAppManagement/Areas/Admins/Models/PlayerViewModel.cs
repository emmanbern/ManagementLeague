using LeagueAppManagement.Data;
using System;

namespace LeagueAppManagement.Areas.Admins.Models
{
    public class PlayerViewModel
    {
        public Guid Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public GradeEnum GradeEnum { get; set; }
        public string Grade
        {
            get
            {
                return GradeEnum.ToString();

            }
        }
    }
}