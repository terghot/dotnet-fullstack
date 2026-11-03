using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class DepartmentLocation
{
    public DepartmentLocation(Guid id, Department departmentId, Location locationId)
    {
        Id = id;
        DepartmentId = departmentId.Id;
        LocationId = locationId.Id;
    }
    public Guid Id { get; }
    public Guid DepartmentId { get; private set; }
    public Guid LocationId { get; private set; }

    //при необходимости:  IsPrimary
}
