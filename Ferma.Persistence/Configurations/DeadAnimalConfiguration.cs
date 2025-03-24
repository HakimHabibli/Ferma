namespace Ferma.Persistence.Configurations;

public class DeadAnimalConfiguration : BaseEntityConfiguration<DeadAnimal> 
{
    public override void Configure(EntityTypeBuilder<DeadAnimal> builder)
    {
        base.Configure(builder); builder.HasKey(x => x.Id);
    }
}
