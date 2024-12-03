using Application.Abstractions.Messaging;

namespace Application.Roles.Commands.UpdateRole;

public sealed record UpdateRoleCommand(
    Guid Id,
    string Name,
    string Description) : ICommand;
