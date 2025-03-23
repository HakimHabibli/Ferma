namespace MyFarm.Models;
// TODO : Ikinci mərhələdir
// Pending əməliyyatlar üçün model
public class PendingOperation : BaseEntity
{
    public string OperationType { get; set; }
    public string TargetTable { get; set; }
    public string? TargetId { get; set; }
    public string? Data { get; set; } // JSON məlumatı
    public string? Status { get; set; }
    public string? RequestedBy { get; set; }
    public string? ApprovedBy { get; set; }
    public string? OperationName { get; set; }
}


