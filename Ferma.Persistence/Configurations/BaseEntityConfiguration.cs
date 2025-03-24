namespace Ferma.Persistence.Configurations;

public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
       builder.HasKey(x => x.Id);
       builder.Property(x => x.CreatedAt)
        .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(x => x.UpdatedAt)
             .HasDefaultValueSql("GETUTCDATE()");
    }
}
