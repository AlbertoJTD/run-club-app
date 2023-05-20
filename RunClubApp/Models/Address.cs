using System.ComponentModel.DataAnnotations;

namespace RunClubApp.Models
{
    public class Address
    {
        // Database Table
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
