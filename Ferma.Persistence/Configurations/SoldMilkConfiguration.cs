namespace Ferma.Persistence.Configurations;

public class SoldMilkConfiguration : BaseEntityConfiguration<SoldMilk>
{
    public override void Configure(EntityTypeBuilder<SoldMilk> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
