using Application.Abstractions.Messaging;

namespace Application.Roles.Commands.CreateRole;

public sealed record CreateRoleCommand(
    string Name,
    string Description) : ICommand<Guid>;
