using Ferma.Persistence.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ferma.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services,IConfiguration configuration) 
    {
        services.AddDbContext<AppDbContext>
            (opt => opt.UseSqlServer
            (configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}
