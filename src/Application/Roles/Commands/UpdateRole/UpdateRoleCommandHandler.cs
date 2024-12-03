using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Commands.UpdateRole;

internal sealed class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateRoleCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result> Handle(UpdateRoleCommand command, CancellationToken cancellationToken)
    {
        var role = await _context.Roles
            .FirstOrDefaultAsync(r => r.Id == command.Id, cancellationToken);

        if (role is null)
        {
            return Result.Failure(RoleErrors.NotFound(command.Id));
        }

        role.UpdateName(command.Name);
        role.UpdateDescription(command.Description);

        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
