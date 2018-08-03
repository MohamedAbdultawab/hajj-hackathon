using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class PersonConfiguration :
        EntityBaseConfiguration<Person, int>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.ToTable("Person");

            builder.HasIndex(p => p.NationalId)
                   .IsUnique();

            builder.Property(p => p.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.MiddleName)
                   .HasMaxLength(50);

            builder.Property(p => p.ThirdName)
                   .HasMaxLength(50);

            builder.Property(p => p.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Ignore(p => p.Name);

            builder.Property(p => p.HomelandId)
                   .IsRequired();

            builder.Property(p => p.NationalId)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.BirthDate)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasMaxLength(100);

            builder.Property(p => p.Mobile)
                   .HasMaxLength(15);

            builder.Property(p => p.Phone)
                   .HasMaxLength(15);

            builder.HasOne(p => p.Homeland)
                   .WithMany(p=>p.Population)
                   .HasForeignKey(p => p.HomelandId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Birthplace)
                   .WithMany()
                   .HasForeignKey(p => p.BirthplaceId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Deathplace)
                   .WithMany()
                   .HasForeignKey(p => p.DeathplaceId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.DeathReason)
                   .WithMany(p=>p.People)
                   .HasForeignKey(p => p.DeathReasonId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.BloodType)
                   .WithMany(p=>p.People)
                   .HasForeignKey(p => p.BloodTypeId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Doctrine)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.DoctrineId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Title)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.TitleId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(p => p.Gender)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.GenderId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.MaritalStatus)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.MaritalStatusId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.CategoryId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Type)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.TypeId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Status)
                   .WithMany(p => p.People)
                   .HasForeignKey(p => p.StatusId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}