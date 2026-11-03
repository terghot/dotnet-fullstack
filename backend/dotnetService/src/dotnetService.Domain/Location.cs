using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class Location
{
    public Location(Guid id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
        CreateAt = DateTime.UtcNow;
        UpdateAt = CreateAt;
    }
    public Guid Id { get; }
    private readonly  List<DepartmentLocation> _locations = [];
    public Department Department { get; private set; } = null!;
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime CreateAt { get; }
    public DateTime UpdateAt { get; set; }
    public IReadOnlyList<DepartmentLocation> Locations => _locations;
}
