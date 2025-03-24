namespace Ferma.Persistence.Configurations;

public class MilkConfiguration : BaseEntityConfiguration<Milk> 
{
    public override void Configure(EntityTypeBuilder<Milk> builder)
    {
        base.Configure(builder);    builder.HasKey(x => x.Id);

    }
}
