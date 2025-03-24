namespace Ferma.Persistence.Configurations;

public class ResidualMilkConfiguration :BaseEntityConfiguration<ResidualMilk>
{
    public override void Configure(EntityTypeBuilder<ResidualMilk> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
