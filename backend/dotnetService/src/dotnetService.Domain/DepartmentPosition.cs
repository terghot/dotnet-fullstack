using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class DepartmentPosition
{

    public DepartmentPosition(Guid id, Guid departmentId, Guid positionid)
    {
        Id = id;
        DepartmentId = departmentId;
        PositionId = positionid;
    }
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid PositionId { get; }
    
}
