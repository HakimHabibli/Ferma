namespace Ferma.Persistence.Configurations;

public class SoldAnimalConfiguration : BaseEntityConfiguration<SoldAnimal>
{
    public override void Configure(EntityTypeBuilder<SoldAnimal> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
