namespace Ferma.Domain.Interface;

// İnterfeys: Sağlamlıq vəziyyətinə nəzarət edən obyektlər üçün
public interface IHealthCheck
{
    string? HealthStatus { get; set; }
}


