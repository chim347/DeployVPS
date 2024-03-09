public class EmergencyCategory : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    /// <summary>
    /// 1. Highest
    /// 2. Giảm dần
    /// </summary>
    public int PriorityLevel { get; set; }
}
