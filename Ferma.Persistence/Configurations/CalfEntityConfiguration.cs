namespace Ferma.Persistence.Configurations;

public class CalfEntityConfiguration : AnimalEntityConfiguration<Calf> 
{
    public override void Configure(EntityTypeBuilder<Calf> builder)
    {
        base.Configure(builder);

    }
}
