using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Configuration
{
    public class EntityBaseConfiguration<TEntity> :
        IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntity
    {

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(p => p.Code)
                   .HasMaxLength(50);
        }
    }

    public class EntityBaseConfiguration<TEntity, TKey> :
        EntityBaseConfiguration<TEntity>
        where TEntity : class, IEntity<TKey>
        where TKey : struct
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();
        }
    }

    public class EntityBaseConfiguration<TEntity, TKey, TName> :
        EntityBaseConfiguration<TEntity, TKey>
        where TEntity : class, IEntity<TKey, TName>
        where TKey : struct
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(256);
        }
    }
}