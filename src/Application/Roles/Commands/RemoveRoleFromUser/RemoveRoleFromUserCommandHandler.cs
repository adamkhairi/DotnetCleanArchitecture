using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Commands.RemoveRoleFromUser;

internal sealed class RemoveRoleFromUserCommandHandler : ICommandHandler<RemoveRoleFromUserCommand>
{
    private readonly IApplicationDbContext _context;

    public RemoveRoleFromUserCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result> Handle(RemoveRoleFromUserCommand command, CancellationToken cancellationToken)
    {
        var role = await _context.Roles
            .FirstOrDefaultAsync(r => r.Id == command.RoleId, cancellationToken);

        if (role is null)
        {
            return Result.Failure(RoleErrors.NotFound(command.RoleId));
        }

        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id == command.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(UserErrors.NotFound(command.UserId));
        }

        role.RemoveUser(user);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
