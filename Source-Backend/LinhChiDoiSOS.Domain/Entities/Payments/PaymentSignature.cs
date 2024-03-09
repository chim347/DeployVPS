using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Domain.Entities.Payments
{
    // chữ kí của payemnt
    public class PaymentSignature : BaseAuditableEntity
    {
        public string? SignValue { get; set; } = string.Empty;
        public string? SignAlgo { get; set; } = string.Empty;
        public string? SignOwn { get; set; } = string.Empty;
        public DateTime? SignDate { get; set; }
        public bool IsValid { get; set; }

        [ForeignKey("Payment")]
        public Guid PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
