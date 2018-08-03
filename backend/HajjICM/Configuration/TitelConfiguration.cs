using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class TitleConfiguration:
        EntityBaseConfiguration<Title, int, string>
    {
        public override void Configure(EntityTypeBuilder<Title> builder)
        {
            base.Configure(builder);

            builder.ToTable("Title");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}