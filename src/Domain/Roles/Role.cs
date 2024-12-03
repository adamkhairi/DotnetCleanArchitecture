using Domain.Permissions;
using Domain.Users;
using SharedKernel;

namespace Domain.Roles;

public sealed class Role : Entity
{
    private readonly List<User> _users = new();
    private readonly List<Permission> _permissions = new();

    private Role(string name, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyCollection<User> Users => _users.AsReadOnly();
    public IReadOnlyCollection<Permission> Permissions => _permissions.AsReadOnly();

    public static Role Create(string name, string description)
    {
        return new Role(name, description);
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateDescription(string description)
    {
        Description = description;
    }

    public void AddUser(User user)
    {
        if (!_users.Contains(user))
        {
            _users.Add(user);
        }
    }

    public void RemoveUser(User user)
    {
        _users.Remove(user);
    }

    public void AddPermission(Permission permission)
    {
        if (!_permissions.Contains(permission))
        {
            _permissions.Add(permission);
        }
    }

    public void RemovePermission(Permission permission)
    {
        _permissions.Remove(permission);
    }
}
