using CodeFirst.EFCore.Data;
using CodeFirst.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirst.EFCore.Domain
{
    public class PersonDomain
    {
        private PersonDbContext _context;

        public PersonDomain(PersonDbContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            person.PersonId = Guid.NewGuid();
            _context.Set<Person>().Add(person);
            _context.SaveChanges();
        }

        public IQueryable<Person> GetAll()
        {
            return _context.Set<Person>().AsQueryable();
        }
    }
}
