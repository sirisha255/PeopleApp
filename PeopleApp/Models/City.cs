using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string? CityName { get; set; }

        public List<Person>? People { get; set; }

        public int CountryId { get; set; }
        public Country? Country { get; set; }

    }
}
