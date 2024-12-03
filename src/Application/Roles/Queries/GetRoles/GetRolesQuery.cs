using Application.Abstractions.Messaging;

namespace Application.Roles.Queries.GetRoles;

public sealed record GetRolesQuery : IQuery<IReadOnlyList<RoleResponse>>;
