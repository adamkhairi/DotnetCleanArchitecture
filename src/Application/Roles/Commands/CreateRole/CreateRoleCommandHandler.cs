using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Domain.Users;
using SharedKernel;

namespace Application.Roles.Commands.CreateRole;

internal sealed class CreateRoleCommandHandler : ICommandHandler<CreateRoleCommand, Guid>
{
    private readonly IApplicationDbContext _context;

    public CreateRoleCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<Guid>> Handle(CreateRoleCommand command, CancellationToken cancellationToken)
    {
        var role = Role.Create(command.Name, command.Description);

        _context.Roles.Add(role);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success(role.Id);
    }
}
