using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class DeathReasonConfiguration :
        EntityBaseConfiguration<DeathReason, int, string>
    {
        public override void Configure(EntityTypeBuilder<DeathReason> builder)
        {
            base.Configure(builder);

            builder.ToTable("DeathReason");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}