using System.ComponentModel.DataAnnotations.Schema;

public class BookingDetail : BaseAuditableEntity
{
    [ForeignKey("Booking")]
    public Guid BookingId { get; set; }
    [ForeignKey("ComboCourse")]
    public Guid ComboCourseId { get; set; }

    public virtual Booking Booking { get; set; }
    public virtual ComboCourse ComboCourse { get; set; }
}
