namespace RunClubApp.Models
{
    public class AppUser
    {
        public int? Pace { get; set; } // ? means that the property can be null
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
