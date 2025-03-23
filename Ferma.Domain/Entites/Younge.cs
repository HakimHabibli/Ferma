namespace MyFarm.Models;
/// <summary>
/// Gənc heyvan (Younge) sinfi
/// </summary>
public class Younge : Animal, IHealthCheck
{
    public string Gender { get; set; }
    public string? HealthStatus { get; set; }
}


