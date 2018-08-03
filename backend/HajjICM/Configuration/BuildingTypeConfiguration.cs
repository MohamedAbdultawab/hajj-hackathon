using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class BuildingTypeConfiguration :
        EntityBaseConfiguration<BuildingType, int, string>
    {
        public override void Configure(EntityTypeBuilder<BuildingType> builder)
        {
            base.Configure(builder);

            builder.ToTable("BuildingType");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}