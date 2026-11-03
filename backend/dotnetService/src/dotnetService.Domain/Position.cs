using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class Position
{
    public Position(Guid id, Guid departmentId)
    {
        Id = id;
        DepartmentId = departmentId;
        CreatedAt = DateTime.UtcNow;
        UpdateAt = CreatedAt;
    }
    public Guid Id { get; set; }
    public Guid DepartmentId { get; }
    public string? Name { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
