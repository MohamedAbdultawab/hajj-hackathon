using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class LanguageConfiguration :
        EntityBaseConfiguration<Language, int, string>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            base.Configure(builder);

            builder.ToTable("Language");

            builder.HasIndex(p => p.Name)
                   .IsUnique();
        }
    }
}