namespace Ferma.Persistence.Configurations;

public class AnimalEntityConfiguration<T> : BaseEntityConfiguration<T> where T : Animal
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);
   
        builder.Property(x => x.Weight).HasMaxLength(10000);
    }
}
