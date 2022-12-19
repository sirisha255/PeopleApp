﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Models;

namespace PeopleApp.Data
{
    public class PeopleDbContext : IdentityDbContext<AppUser>
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        {
        }
        public DbSet<Person>? People { get; set; } = default;
        public DbSet<City>? Cities { get; set; } = default;
        public DbSet<Country>? Countries { get; set; } = default;
        public DbSet<Language>? Languages { get; set; } = default;

    }
}
