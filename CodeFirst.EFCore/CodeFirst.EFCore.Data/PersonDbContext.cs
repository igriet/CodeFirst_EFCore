using CodeFirst.EFCore.Data.EntityConfig;
using CodeFirst.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.EFCore.Data
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public PersonDbContext() { }

        public PersonDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PersonEntityConfig.SetEntityBuilder(modelBuilder.Entity<Person>());
            PhoneEntityConfig.SetEntityBuilder(modelBuilder.Entity<Phone>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
