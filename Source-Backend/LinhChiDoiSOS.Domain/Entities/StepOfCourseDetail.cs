using System.ComponentModel.DataAnnotations.Schema;

public class StepOfCourseDetail : BaseAuditableEntity
{
    public string? StepName { get; set; }
    public string? StepContent { get; set; }
    [ForeignKey("CourseDetail")]
    public Guid CourseDetailId { get; set; }

    public virtual CourseDetail CourseDetail { get; set; }
}