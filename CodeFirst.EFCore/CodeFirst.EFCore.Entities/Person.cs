using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.EFCore.Entities
{
    //[Table("Person")]
    //public class Person
    //{
    //    [Key]
    //    public Guid PersonID { get; set; }
    //    public DateTime BirthDate { get; set; }
    //    public string Name { get; set; }
    //    public int RandomNumber { get; set; }

    //    public virtual ICollection<Phone> Phones { get; set; }
    //}

    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
