using Domain.Todos;
using Domain.Users;
using Domain.Permissions;
using Domain.Roles;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<TodoItem> TodoItems { get; }
    DbSet<Permission> Permissions { get; }
    DbSet<Role> Roles { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
