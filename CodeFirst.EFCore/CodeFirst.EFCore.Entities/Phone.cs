using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst.EFCore.Entities
{
    [Table("Phone")]
    public class Phone
    {
        [Key]
        public Guid PhoneId { get; set; }
        public string Telephone { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
