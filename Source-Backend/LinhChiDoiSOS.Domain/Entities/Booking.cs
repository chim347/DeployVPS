using LinhChiDoiSOS.Domain.Entities.Payments;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Booking : BaseAuditableEntity
    {
        public double? Price { get; set; }

        /*[ForeignKey("Payment")]
        public Guid PaymentId {  get; set; }*/
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }

        //public virtual Payment Payment { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
