﻿using Microsoft.AspNetCore.Identity;

namespace PeopleApp.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? UserName { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
