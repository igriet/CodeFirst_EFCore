using System;
using System.Collections.Generic;
using CodeFirst.EFCore.Data;
using CodeFirst.EFCore.Domain;
using CodeFirst.EFCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.EFCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Phone")]
    public class PhoneController : Controller
    {
        private PersonDbContext _context;
        private readonly PhoneDomain _domain;

        public PhoneController(PersonDbContext context)
        {
            _context = context;
            _domain = new PhoneDomain(_context);
        }

        // GET: api/Phone
        [HttpGet]
        public IEnumerable<Phone> Get()
        {
            return _domain.GetAll();
        }

        // GET: api/Phone/5
        [HttpGet("{id}", Name = "GetPhone")]
        public Phone Get(Guid id)
        {
            return _domain.GetById(id);
        }

        // POST: api/Phone
        [HttpPost]
        public void Post([FromBody]Phone value)
        {
            _domain.AddPhone(value);
        }

        // PUT: api/Phone/5
        [HttpPut]
        public void Put([FromBody]Phone value)
        {
            _domain.UpdatePhone(value);
        }

        // DELETE: api/Phone/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _domain.DeletePhone(id);
        }
    }
}