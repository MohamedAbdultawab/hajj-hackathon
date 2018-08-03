using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class BloodTypeConfiguration :
        EntityBaseConfiguration<BloodType, int, string>
    {
        public override void Configure(EntityTypeBuilder<BloodType> builder)
        {
            base.Configure(builder);

            builder.ToTable("BloodType");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.HasIndex(p => p.Symbol)
                   .IsUnique();

            builder.Property(p => p.Symbol)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.HasOne(p => p.Group)
                   .WithMany(p => p.BloodTypes)
                   .HasForeignKey(p => p.GroupId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}