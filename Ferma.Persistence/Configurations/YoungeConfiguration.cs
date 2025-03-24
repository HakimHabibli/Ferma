namespace Ferma.Persistence.Configurations;

public class YoungeConfiguration : AnimalEntityConfiguration<Younge> 
{
    public override void Configure(EntityTypeBuilder<Younge> builder)
    {
        base.Configure(builder); builder.HasKey(x => x.Id);

    }
}