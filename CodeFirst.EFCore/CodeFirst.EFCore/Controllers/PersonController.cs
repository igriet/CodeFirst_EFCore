using System;
using System.Collections.Generic;
using CodeFirst.EFCore.Data;
using CodeFirst.EFCore.Domain;
using CodeFirst.EFCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.EFCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private PersonDbContext _context;
        private readonly PersonDomain _domain;

        public PersonController(PersonDbContext context)
        {
            _context = context;
            _domain = new PersonDomain(_context);
        }
        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _domain.GetAll();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "GetPerson")]
        public Person Get(Guid id)
        {
            return _domain.GetById(id);
        }

        // POST: api/Person
        [HttpPost]
        public void Post([FromBody]Person value)
        {
            _domain.AddPerson(value);
        }
        
        // PUT: api/Person/5
        [HttpPut]
        public void Put([FromBody]Person value)
        {
            _domain.UpdatePerson(value);
        }
        
        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _domain.DeletePerson(id);
        }
    }
}
