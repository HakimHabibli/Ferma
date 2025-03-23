namespace MyFarm.Models;

// İnek (Cow) sinfi
public class Cow : Animal, IMilkProducing
{
    public List<DateTime>? InseminationDates { get; set; } // JSON saxlanacaq
    public int? ChildCount { get; set; }
    public string Username { get; set; }
    public decimal? MilkProduction { get; set; }
}


