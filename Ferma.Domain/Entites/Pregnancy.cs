namespace MyFarm.Models;
/// <summary>
/// Hamiləlik (Pregnancy) sinfi
/// </summary>
public class Pregnancy : BaseEntity
{
    public string BilkaNumber { get; set; }
    public List<string>? AnimalData { get; set; } // JSON məlumatı
    public List<DateTime> SelectedInseminationDate { get; set; }
    public DateTime? LeftDay { get; set; }
    public DateTime? SevenMonth { get; set; }
    public DateTime? LastTwoWeeks { get; set; }
}


