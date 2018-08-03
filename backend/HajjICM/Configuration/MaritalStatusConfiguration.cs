using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class MaritalStatusConfiguration:
        EntityBaseConfiguration<MaritalStatus, int, string>
    {
        public override void Configure(EntityTypeBuilder<MaritalStatus> builder)
        {
            base.Configure(builder);

            builder.ToTable("MaritalStatus");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}