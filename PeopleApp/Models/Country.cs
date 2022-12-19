﻿namespace PeopleApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? CountryName { get; set; }

        public Country(string? countryName)
        {
            CountryName = countryName;
        }

        public List<City> Cities { get; set; }
    }
}
