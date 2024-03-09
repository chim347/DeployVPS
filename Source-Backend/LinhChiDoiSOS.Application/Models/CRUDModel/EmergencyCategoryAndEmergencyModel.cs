namespace LinhChiDoiSOS.Application.Models.CRUDModel
{
    public class EmergencyCategoryAndEmergencyModel
    {
        public Guid EmergencyCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<EmergencyModel>? EmergencyModels { get; set; }
    }
}
