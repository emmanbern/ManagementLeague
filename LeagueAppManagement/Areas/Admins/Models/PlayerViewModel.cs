using LeagueAppManagement.Data;
using LeagueAppManagement.Services;
using System;
using System.Collections.Generic;

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

        public List<KeyValuePair<string, int>> EnumList
        {
            get
            {
                var _service = new EnumerationService();
                return _service.GetEnumerationValues<GradeEnum>();
            }
        }
    }
}