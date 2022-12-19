using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }
        public Person() { }
        public Person(int id, string name, string phoneNumber, string cityName)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            CityName = cityName;
        }

        public City City{get; set;}
        public int CityId { get; set;}
        //public List<PersonLanguage> PersonLanguages { get; set; }

    }
}
