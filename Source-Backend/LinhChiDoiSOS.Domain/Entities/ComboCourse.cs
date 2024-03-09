using System.ComponentModel.DataAnnotations.Schema;

public class ComboCourse : BaseAuditableEntity
{
    public string? Name { get; set; }

    public IList<Course> Course { get; set; }
}
