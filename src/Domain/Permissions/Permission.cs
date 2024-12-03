using Domain.Roles;
using System.Collections.ObjectModel;

namespace Domain.Permissions;

public sealed class Permission
{
    private readonly List<Role> _roles = new();

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyCollection<Role> Roles => _roles.AsReadOnly();

    private Permission() { }

    private Permission(string name, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    public static Permission Create(string name, string description)
    {
        return new Permission(name, description);
    }
}
