namespace Ferma.Persistence.Configurations;

public class PendingOperationConfiguration : BaseEntityConfiguration<PendingOperation>
{
    public override void Configure(EntityTypeBuilder<PendingOperation> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);

    }
}
