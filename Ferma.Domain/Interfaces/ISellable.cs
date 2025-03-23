namespace Ferma.Domain.Interface;
/// <summary>
///  İnterfeys: Satıla bilən heyvanlar üçün
/// </summary>
public interface ISellable
{
    double? SoldPrice { get; set; }
    string? SoldTo { get; set; }
    string? Info { get; set; }
}


