using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonLanguageConfiguration :
        EntityBaseConfiguration<PersonLanguage>
    {
        public override void Configure(EntityTypeBuilder<PersonLanguage> builder)
        {
            base.Configure(builder);

            builder.ToTable("PersonLanguage");

            builder.HasKey(p => new
            {
                p.PersonId,
                p.LanguageId
            });

            builder.Property(p => p.PersonId)
                   .IsRequired();

            builder.Property(p => p.LanguageId)
                   .IsRequired();

            builder.HasOne(p => p.Person)
                   .WithMany(p => p.Languages)
                   .HasForeignKey(p => p.PersonId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Language)
                   .WithMany(p => p.Speakers)
                   .HasForeignKey(p => p.LanguageId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}