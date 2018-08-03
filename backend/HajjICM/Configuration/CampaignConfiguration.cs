using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class CampaignConfiguration :
        EntityBaseConfiguration<Campaign, int, string>
    {
        public override void Configure(EntityTypeBuilder<Campaign> builder)
        {
            base.Configure(builder);

            builder.ToTable("Campaign");

            builder.HasIndex(p => p.Name)
                   .IsUnique();

            builder.HasOne(p => p.Supervisor)
                   .WithMany()
                   .HasForeignKey(p => p.SupervisorId)
                   .HasPrincipalKey(p => p.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}