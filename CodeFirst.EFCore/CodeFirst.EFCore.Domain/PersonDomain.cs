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

        public Person GetById(Guid id)
        {
            return _context.People.FirstOrDefault(p => p.PersonId == id);
        }

        public void UpdatePerson(Person person)
        {
            Person oldPerson = this.GetById(person.PersonId);
            oldPerson.Name = person.Name;
            _context.Set<Person>().Update(oldPerson);
            _context.SaveChanges();
        }

        public void DeletePerson(Guid id)
        {
            Person person = this.GetById(id);
            _context.Set<Person>().Remove(person);
            _context.SaveChanges();
        }
    }
}
