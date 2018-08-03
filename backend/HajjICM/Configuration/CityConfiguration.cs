using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class CityConfiguration :
        EntityBaseConfiguration<City, int, string>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);

            builder.ToTable("City");

            builder.HasIndex(p => new
            {
                p.CountryId,
                p.Name
            }).IsUnique();

            builder.Property(p => p.CountryId)
                   .IsRequired();

            builder.HasOne(p => p.Country)
                   .WithMany(p => p.Cities)
                   .HasForeignKey(p => p.CountryId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}