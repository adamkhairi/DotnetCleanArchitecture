using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Commands.AssignRoleToUser;

internal sealed class AssignRoleToUserCommandHandler : ICommandHandler<AssignRoleToUserCommand>
{
    private readonly IApplicationDbContext _context;

    public AssignRoleToUserCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result> Handle(AssignRoleToUserCommand command, CancellationToken cancellationToken)
    {
        Role? role = await _context.Roles
            .FirstOrDefaultAsync(r => r.Id == command.RoleId, cancellationToken);

        if (role is null)
        {
            return Result.Failure(RoleErrors.NotFound(command.RoleId));
        }

        User? user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id == command.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(UserErrors.NotFound(command.UserId));
        }

        role.AddUser(user);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
