namespace Ferma.Domain.Common;
/// <summary>
/// Bütün varlıqlar üçün baza sinfi
/// </summary>
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}


