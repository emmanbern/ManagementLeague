using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueAppManagement.Data
{
    public class Player : BaseEntity
    {
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public GradeEnum Grade { get; set; }
        public Team Team { get; set; }
    }
}