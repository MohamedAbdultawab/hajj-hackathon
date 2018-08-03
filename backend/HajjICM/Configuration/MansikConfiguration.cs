using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class MansikConfiguration :
        EntityBaseConfiguration<Mansik, int, string>
    {
        public override void Configure(EntityTypeBuilder<Mansik> builder)
        {
            base.Configure(builder);

            builder.ToTable("Mansik");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.HasIndex(p => p.Order)
                   .IsUnique();

            builder.HasIndex(p => p.StartDate)
                   .IsUnique();

            builder.HasIndex(p => p.Longitude)
                   .IsUnique();

            builder.HasIndex(p => p.Latitude)
                   .IsUnique();
        }
    }
}