using CodeFirst.EFCore.Data;
using CodeFirst.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirst.EFCore.Domain
{
    public class PhoneDomain
    {
        private PersonDbContext _context;

        public PhoneDomain(PersonDbContext context)
        {
            _context = context;
        }

        public void AddPhone(Phone phone)
        {
            phone.PhoneId = Guid.NewGuid();
            _context.Set<Phone>().Add(phone);
            _context.SaveChanges();
        }

        public IQueryable<Phone> GetAll()
        {
            return _context.Set<Phone>().AsQueryable();
        }

        public Phone GetById(Guid id)
        {
            return _context.Phones.FirstOrDefault(p => p.PhoneId == id);
        }

        public void UpdatePhone(Phone phone)
        {
            Phone oldPhone = this.GetById(phone.PhoneId);
            oldPhone.Telephone = phone.Telephone;
            _context.Set<Phone>().Update(oldPhone);
            _context.SaveChanges();
        }

        public void DeletePhone(Guid id)
        {
            Phone phone = this.GetById(id);
            _context.Set<Phone>().Remove(phone);
            _context.SaveChanges();
        }
    }
}
