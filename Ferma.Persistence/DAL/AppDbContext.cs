using System.Reflection;

namespace Ferma.Persistence.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Calf> Calves { get; set; }
    public DbSet<Cow> Cows { get; set; }
    public DbSet<DeadAnimal> DeadAnimals { get; set; }
    public DbSet<Milk> Milk { get; set; }
    public DbSet<Pregnancy> Pregnancies { get; set; }
    public DbSet<ResidualMilk> ResidualMilk { get; set; }
    public DbSet<SoldAnimal> SoldAnimals { get; set; }
    public DbSet<SoldMilk> SoldMilk { get; set; }
    public DbSet<Tank> Tanks { get; set; }
    public DbSet<Younge> Younges { get; set; }
    public DbSet<PendingOperation> PendingOperations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
