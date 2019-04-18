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
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("CodeFirstEFCoreDBConnection");
        //    base.OnConfiguring(optionsBuilder);
        //}

        //public DbSet<Person> People { get; set; }
        //public DbSet<Phone> Phones { get; set; }
        public PersonDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
