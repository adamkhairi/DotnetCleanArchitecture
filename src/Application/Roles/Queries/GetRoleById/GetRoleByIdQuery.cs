using Application.Abstractions.Messaging;

namespace Application.Roles.Queries.GetRoleById;

public sealed record GetRoleByIdQuery(Guid Id) : IQuery<RoleResponse>;
