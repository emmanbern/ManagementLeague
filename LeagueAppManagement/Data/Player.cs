namespace LeagueAppManagement.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public GradeEnum Grade { get; set; }
    }
}