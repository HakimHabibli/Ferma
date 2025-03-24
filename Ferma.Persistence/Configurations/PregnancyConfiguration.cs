namespace Ferma.Persistence.Configurations;

public class PregnancyConfiguration : BaseEntityConfiguration<Pregnancy> 
{
    public override void Configure(EntityTypeBuilder<Pregnancy> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
