using Application.Abstractions.Messaging;

namespace Application.Roles.Commands.RemoveRoleFromUser;

public sealed record RemoveRoleFromUserCommand(
    Guid RoleId,
    Guid UserId) : ICommand;
