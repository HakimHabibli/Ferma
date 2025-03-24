namespace MyFarm.Models;
/// <summary>
/// Satılmış heyvan (SoldAnimal) sinfi
/// </summary>
public class SoldAnimal : BaseEntity, ISellable
{
    public string BilkaNumber { get; set; }
    public List<string>? AnimalData { get; set; } // JSON məlumatı
    public string Type { get; set; }
    public double? SoldPrice { get; set; }
    public string? SoldTo { get; set; }
    public string? Info { get; set; }
}


