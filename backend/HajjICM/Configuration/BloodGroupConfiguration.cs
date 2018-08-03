using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class BloodGroupConfiguration :
        EntityBaseConfiguration<BloodGroup, int, string>
    {
        public override void Configure(EntityTypeBuilder<BloodGroup> builder)
        {
            base.Configure(builder);

            builder.ToTable("BloodGroup");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.HasIndex(p => p.Symbol)
                   .IsUnique();

            builder.Property(p => p.Symbol)
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}