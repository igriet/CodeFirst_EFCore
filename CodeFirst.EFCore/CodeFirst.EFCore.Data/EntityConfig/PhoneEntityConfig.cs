using CodeFirst.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.EFCore.Data.EntityConfig
{
    public class PhoneEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Phone> entityBuilder)
        {
            entityBuilder.ToTable("Phones");
            entityBuilder.HasKey(x => x.PhoneId);
            entityBuilder.Property(x => x.PhoneId).IsRequired();
        }
    }
}
