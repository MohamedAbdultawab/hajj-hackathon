using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class CountryConfiguration :
        EntityBaseConfiguration<Country, int, string>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);

            builder.ToTable("Country");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.Property(p => p.Nationality)
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}