using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class AddressTypeConfiguration:
        EntityBaseConfiguration<AddressType, int, string>
    {
        public override void Configure(EntityTypeBuilder<AddressType> builder)
        {
            base.Configure(builder);

            builder.ToTable("AddressType");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}