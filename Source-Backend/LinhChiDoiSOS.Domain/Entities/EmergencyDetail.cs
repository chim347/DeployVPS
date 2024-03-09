using System.ComponentModel.DataAnnotations.Schema;

public class EmergencyDetail : BaseAuditableEntity
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
    public bool IsSafe { get;set; }

    [ForeignKey("Emergency")]
    public Guid? EmergencyId { get; set; }

    public virtual Emergency Emergency { get; set; }
    public List<MiniContent>? ListMiniContent { get; set; }
    public List<AnswerContent>? ListAnswerContent { get; set; }
}
