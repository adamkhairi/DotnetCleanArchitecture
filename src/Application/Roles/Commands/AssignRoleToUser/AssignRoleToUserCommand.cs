using Application.Abstractions.Messaging;

namespace Application.Roles.Commands.AssignRoleToUser;

public sealed record AssignRoleToUserCommand(
    Guid RoleId,
    Guid UserId) : ICommand;
