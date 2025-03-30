namespace MyFarm.Models;
// TODO: Süd ikinci mərhələdir ,Çən yazılmalıdı 
// Süd istehsalı (Milk) sinfi
public class Milk : BaseEntity
{
    public DateTime Date { get; set; }
    public decimal? Morning { get; set; }
    public decimal? Night { get; set; }
    public decimal Total { get; set; }
    public decimal? UsedMilk { get; set; }
    public List<string>? OtherInfo { get; set; }
    public List<Tank> Tanks { get; set; }

}
public class Tank : BaseEntity
{ 
    public string Name { get; set; }
    public double Capacity { get; set; }
    public List<Milk> Milks { get; set; }
}

