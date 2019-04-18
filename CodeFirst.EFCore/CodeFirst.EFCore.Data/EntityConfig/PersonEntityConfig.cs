using CodeFirst.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.EFCore.Data.EntityConfig
{
    public class PersonEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Person> entityBuilder)
        {
            entityBuilder.ToTable("People");
            entityBuilder.HasKey(x => x.PersonId);
            entityBuilder.Property(x => x.PersonId).IsRequired();

            entityBuilder.HasMany(x => x.Phone).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);
        }
    }
}
