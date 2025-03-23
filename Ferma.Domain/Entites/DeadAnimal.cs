namespace MyFarm.Models;

// Ölmüş heyvan (DeadAnimal) sinfi
public class DeadAnimal : BaseEntity
{
    public int BilkaNumber { get; set; }
    public string? AnimalData { get; set; } // JSON məlumatı
    public string Type { get; set; }
    public string? DeadReason { get; set; }
}


