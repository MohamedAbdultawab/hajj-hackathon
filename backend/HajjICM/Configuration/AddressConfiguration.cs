using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class AddressConfiguration :
        EntityBaseConfiguration<Address, long>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.ToTable("Address");

            builder.Property(p => p.CountryId)
                   .IsRequired();
            
            builder.HasOne(p => p.Country)
                   .WithMany()
                   .HasForeignKey(p => p.CountryId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.City)
                   .WithMany()
                   .HasForeignKey(p => p.CityId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.BuildingType)
                   .WithMany(p => p.Addresses)
                   .HasForeignKey(p => p.BuildingTypeId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}