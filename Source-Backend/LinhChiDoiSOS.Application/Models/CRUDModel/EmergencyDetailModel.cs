using System.ComponentModel.DataAnnotations.Schema;

namespace LinhChiDoiSOS.Application.Models.CRUDModel
{
    public class EmergencyDetailModel
    {
        public int Step { get; set; }
        public string? TopContent { get; set; }
        public string? ContentLeft { get; set; }
        public string? ContentLeftUrl { get; set; }
        public string? ContentRight { get; set; }
        public string? ContentRightUrl { get; set; }
        public string? MainPictureUrl { get; set; }
        public string? ActionContent { get; set; }
        public string? ContentBottom { get; set; }

        /// <summary>
        /// Đánh dấu xem tới bước an toàn chưa, bước an toàn thì là màu xanh trên UI
        /// </summary>
        public bool IsSafe { get; set; }
        public Guid? EmergencyId { get; set; }

        public List<MiniContentModelOfED>? MiniContentModelOfEDs { get; set; }
        public List<AnswerContentModelOfED>? AnswerContentModelOfEDs { get; set; }
    }
    public class MiniContentModelOfED
    {
        public Guid EmergencyDetailId { get; set; }
        public string? ContentUrl { get; set; }
        public string? Content { get; set; }
    }
    public class AnswerContentModelOfED
    {
        public Guid EmergencyDetailId { get; set; }
        public string? Answer { get; set; }
        public int NextStepAfterAnswer { get; set; }
    }
}
