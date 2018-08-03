using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class GenderConfiguration:
        EntityBaseConfiguration<Gender, int, string>
    {
        public override void Configure(EntityTypeBuilder<Gender> builder)
        {
            base.Configure(builder);

            builder.ToTable("Gender");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}