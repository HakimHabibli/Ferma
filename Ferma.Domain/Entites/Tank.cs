namespace MyFarm.Models;

public class Tank : BaseEntity
{ 
    public string Name { get; set; }
    public double Capacity { get; set; }
    public double TotalMilk { get; set; }
    public List<Milk> Milks { get; set; }
}

