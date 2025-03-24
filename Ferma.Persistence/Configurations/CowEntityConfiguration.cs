namespace Ferma.Persistence.Configurations;

public class CowEntityConfiguration : AnimalEntityConfiguration<Cow>
{
    public override void Configure(EntityTypeBuilder<Cow> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
