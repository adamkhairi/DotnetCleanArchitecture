using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Authorization;

internal sealed class PermissionProvider
{
    private readonly ApplicationDbContext _dbContext;

    public PermissionProvider(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> UserHasPermissionAsync(Guid userId, string permission)
    {
        List<string> rolePermissions = await _dbContext.Users
            .Where(u => u.Id == userId)
            .SelectMany(u => u.Roles.SelectMany(r => r.Permissions.Select(p => p.Name)))
            .ToListAsync();

        return rolePermissions.Contains(permission);
    }
}
