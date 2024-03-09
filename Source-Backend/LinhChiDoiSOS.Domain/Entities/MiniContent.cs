using System.ComponentModel.DataAnnotations.Schema;

public class MiniContent : BaseAuditableEntity
{
    [ForeignKey("EmergencyDetail")]
    public Guid EmergencyDetailId { get; set; }
    public string? ContentUrl { get; set; }
    public string? Content { get; set; }
    public virtual EmergencyDetail Emergency { get; set; }
}
