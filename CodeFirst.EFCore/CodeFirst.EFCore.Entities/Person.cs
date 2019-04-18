using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.EFCore.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Phone> Phone { get; set; }
    }
}
