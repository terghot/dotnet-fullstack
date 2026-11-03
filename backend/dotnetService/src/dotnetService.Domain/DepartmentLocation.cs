using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class DepartmentLocation
{
    public DepartmentLocation(Guid id, Guid departmentId, Guid locationId)
    {
        Id = id;
        DepartmentId = departmentId;
        LocationId = locationId;
    }
    public Guid Id { get; }
    public Guid DepartmentId { get; private set; }
    public Guid LocationId { get; private set; }

    //при необходимости:  IsPrimary
}
