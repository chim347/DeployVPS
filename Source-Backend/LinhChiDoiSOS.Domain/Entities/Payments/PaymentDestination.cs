namespace LinhChiDoiSOS.Domain.Entities.Payments
{
    // đích thanh toán của cái payment
    public class PaymentDestination : BaseAuditableEntity
    {
        public string? DesName { get; set; } = string.Empty;
        public string? DesShortName { get; set; } = string.Empty;
        public string? DesParentId { get; set; } = string.Empty;
        public string? DesLogo { get; set; } = string.Empty;
        // thứu tự sắp xếp để hiện thị
        public int SortIndex { get; set; }
        public bool IsActive { get; set; }

        public virtual IList<Payment> Payment { get; set; }
    }
}
