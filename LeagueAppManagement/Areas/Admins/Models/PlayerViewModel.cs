using LeagueAppManagement.Data;
using LeagueAppManagement.Services;
using System;
using System.Collections.Generic;

namespace LeagueAppManagement.Areas.Admins.Models
{
    public class PlayerViewModel
    {
        private EnumerationService _service;

        public PlayerViewModel()
        {
            _service = new EnumerationService();
        }
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
        public PositionEnum PositionEnum { get; set; }

        public string Grade
        {
            get
            {
                return GradeEnum.ToString();

            }
        }

        public string Position
        {
            get
            {
                return PositionEnum.ToString();
            }
        }


        public List<KeyValuePair<string, int>> GradeEnumList
        {
            get
            {

                return _service.GetEnumerationValues<GradeEnum>();
            }
        }

        public List<KeyValuePair<string, int>> PositionEnumList
        {
            get
            {
                return _service.GetEnumerationValues<PositionEnum>();
            }
        }
    }
}