using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonTypeConfiguration:
        EntityBaseConfiguration<PersonType, int, string>
    {
        public override void Configure(EntityTypeBuilder<PersonType> builder)
        {
            base.Configure(builder);

            builder.ToTable("PersonType");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}