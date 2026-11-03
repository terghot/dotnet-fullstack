using System.Diagnostics.Contracts;
using System.Dynamic;

namespace DotnetService.Domain;

public class Department

{
    public Department(Guid id, string name, string slug, string path, Guid parentId, IEnumerable<Location> locations)
    {
        Id = id;
        Name = name;
        Slug = slug;
        Path = path;
        ParentId = parentId;
        CreateAt = DateTime.UtcNow;
        UpdateAt = CreateAt;
        _location = locations.ToList();
    }

    public Guid Id { get; }

    private readonly List<Location> _location;

    public string Name { get; private set; }

    public string Slug { get; private set; }

    public string Path { get; private set; }

    public Guid ParentId { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public int LocationCount => _location.Count;

    public IReadOnlyCollection<Location> Locations => _location;
}
