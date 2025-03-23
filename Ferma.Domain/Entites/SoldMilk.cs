namespace MyFarm.Models;
/// <summary>
/// Satılmış süd (SoldMilk) sinfi
/// </summary>
public class SoldMilk : BaseEntity, ISellable
{
    public DateTime Date { get; set; }
    public string SoldTo { get; set; }
    public double Quantity { get; set; }
    public double Total { get; set; }
    public double Price { get; set; }
    public string? OtherInfo { get; set; }
    public double? SoldPrice { get; set; }
    public string? Info { get; set; }
}


