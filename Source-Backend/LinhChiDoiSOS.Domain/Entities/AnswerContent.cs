using System.ComponentModel.DataAnnotations.Schema;

public class AnswerContent : BaseAuditableEntity
{

    [ForeignKey("EmergencyDetail")]
    public Guid EmergencyDetailId { get; set; }
    public string? Answer { get; set; }
    public int NextStepAfterAnswer { get; set; }
    public virtual EmergencyDetail Emergency { get; set; }
}