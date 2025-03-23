namespace MyFarm.Models;
// TODO: Süd ikinci mərhələdir 
// Süd istehsalı (Milk) sinfi
public class Milk : BaseEntity
{
    public DateTime Date { get; set; }
    public decimal? Morning { get; set; }
    public decimal? Night { get; set; }
    public decimal Total { get; set; }
    public decimal? UsedMilk { get; set; }
    public List<string>? OtherInfo { get; set; }
}


