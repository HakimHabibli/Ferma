using Ferma.Domain.Enums;

namespace Ferma.Application.DTO_s.CommonDto;

public abstract class AnimalDto : BaseEntityDto
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
public class CalfDto:AnimalDto 
{
      public Gender Gender { get; set; }    
}
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }
public class CowDto : AnimalDto { }