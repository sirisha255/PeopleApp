using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        public string? LanguageName { get; set; }
        public List<Person> people { get; set; }
    }
}
