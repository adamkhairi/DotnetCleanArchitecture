using Application.Abstractions.Messaging;

namespace Application.Roles.Commands.DeleteRole;

public sealed record DeleteRoleCommand(Guid Id) : ICommand;
