using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonStatusConfiguration:
        EntityBaseConfiguration<PersonStatus, int, string>
    {
        public override void Configure(EntityTypeBuilder<PersonStatus> builder)
        {
            base.Configure(builder);

            builder.ToTable("PersonStatus");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}