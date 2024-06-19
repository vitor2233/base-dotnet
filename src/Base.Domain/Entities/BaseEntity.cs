using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entities;

[Table("T_BASE")]
public class BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
