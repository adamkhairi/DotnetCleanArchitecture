using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Commands.DeleteRole;

internal sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteRoleCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result> Handle(DeleteRoleCommand command, CancellationToken cancellationToken)
    {
        Role? role = await _context.Roles
            .FirstOrDefaultAsync(r => r.Id == command.Id, cancellationToken);

        if (role is null)
        {
            return Result.Failure(RoleErrors.NotFound(command.Id));
        }

        _context.Roles.Remove(role);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
