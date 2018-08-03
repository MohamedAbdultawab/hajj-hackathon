using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class DoctrineConfiguration:
        EntityBaseConfiguration<Doctrine, int, string>
    {
        public override void Configure(EntityTypeBuilder<Doctrine> builder)
        {
            base.Configure(builder);

            builder.ToTable("Doctrine");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}