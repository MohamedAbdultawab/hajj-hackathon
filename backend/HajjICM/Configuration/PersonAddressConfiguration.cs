using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonAddressConfiguration:
        EntityBaseConfiguration<PersonAddress>
    {
        public override void Configure(EntityTypeBuilder<PersonAddress> builder)
        {
            base.Configure(builder);

            builder.ToTable("PersonAddress");

            builder.HasKey(p => new
            {
                p.PersonId,
                p.AddressId,
                p.TypeId
            });

            builder.Property(p => p.PersonId)
                   .IsRequired();

            builder.Property(p => p.AddressId)
                   .IsRequired();

            builder.Property(p => p.TypeId)
                   .IsRequired();

            builder.HasOne(p => p.Person)
                   .WithMany(p => p.Addresses)
                   .HasForeignKey(p => p.PersonId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Address)
                   .WithMany()
                   .HasForeignKey(p => p.AddressId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Type)
                   .WithMany(p => p.Addresses)
                   .HasForeignKey(p => p.TypeId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}