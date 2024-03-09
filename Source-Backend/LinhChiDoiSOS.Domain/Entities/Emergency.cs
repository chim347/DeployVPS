using System.ComponentModel.DataAnnotations.Schema;

public class Emergency : BaseAuditableEntity
{
    public string? Title { get; set; }
    public string? Image {  get; set; }

    [ForeignKey("EmergencyCategory")]
    public Guid EmergencyCategoryId {  get; set; }

    public virtual EmergencyCategory EmergencyCategory { get; set; }
}