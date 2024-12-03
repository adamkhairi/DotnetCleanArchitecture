namespace Application.Roles.Queries.GetRoleById;

public sealed record RoleResponse(
    Guid Id,
    string Name,
    string Description,
    IReadOnlyList<string> Permissions,
    IReadOnlyList<UserInRoleResponse> Users);

public sealed record UserInRoleResponse(
    Guid Id,
    string Email,
    string FirstName,
    string LastName);
