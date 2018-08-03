using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonCategoryConfiguration:
        EntityBaseConfiguration<PersonCategory, int, string>
    {
        public override void Configure(EntityTypeBuilder<PersonCategory> builder)
        {
            base.Configure(builder);

            builder.ToTable("PersonCategory");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}