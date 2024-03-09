using LinhChiDoiSOS.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities.Payments
{
    // thanh toán
    public class Payment : BaseAuditableEntity
    {
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        // mã tham chiếu đến đơn hàng từ merchant
        public string PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? ExpireDate { get; set; }
        public string? PaymentLanguage { get; set; } = string.Empty;
        public decimal? PaidAmount { get; set; }
        public string? PaymentStatus { get; set; } = string.Empty;
        public string? PaymentLastMessage { get; set; } = string.Empty;

        [ForeignKey("Merchant")]
        public Guid MerchantId { get; set; }
        [ForeignKey("PaymentDestination")]
        public Guid PaymentDestinationId { get; set; }

        // relationShip
        public virtual Merchant Merchant { get; set; }
        public virtual PaymentDestination PaymentDestination { get; set; }
        public virtual IList<PaymentSignature> PaymentSignature { get; set; }
        public virtual IList<PaymentTransaction> PaymentTransaction { get; set; }
    }
}
