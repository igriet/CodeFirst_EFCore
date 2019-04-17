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
        public PersonDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
