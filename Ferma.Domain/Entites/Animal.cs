namespace MyFarm.Models;

/// <summary>
/// Heyvanların əsas xüsusiyyətlərini birləşdirən abstrakt sinif
/// </summary>
public abstract class Animal : BaseEntity
{
    public string BilkaNumber { get; set; }
    public string? Name { get; set; }
    public double? Weight { get; set; }
    public DateTime? Birthdate { get; set; }
    public string Type { get; set; }
    public string? MotherBilka { get; set; }
    public string? HowGet { get; set; }
    public string? GetFrom { get; set; }
    public List<string>? OtherInfo { get; set; }
    public DateTime? LastCheckupDate { get; set; }
}


