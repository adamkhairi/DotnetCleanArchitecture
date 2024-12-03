namespace Application.Roles.Queries.GetRoles;

public sealed record RoleResponse(
    Guid Id,
    string Name,
    string Description,
    int UserCount,
    int PermissionCount);
