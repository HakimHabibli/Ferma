namespace MyFarm.Models;
/// <summary>
/// Süd qalığı (ResidualMilk) sinfi
/// </summary>
public class ResidualMilk : BaseEntity
{
    public DateTime Date { get; set; }
    public decimal TotalMilk { get; set; }
}


