using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Roles;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Queries.GetRoleById;

internal sealed class GetRoleByIdQueryHandler(IApplicationDbContext context)
    : IQueryHandler<GetRoleByIdQuery, RoleResponse>
{
    public async Task<Result<RoleResponse>> Handle(GetRoleByIdQuery query, CancellationToken cancellationToken)
    {
        Role? role = await context.Roles
            .Include(r => r.Permissions)
            .Include(r => r.Users)
            .FirstOrDefaultAsync(r => r.Id == query.Id, cancellationToken);

        if (role is null)
        {
            return Result.Failure<RoleResponse>(RoleErrors.NotFound(query.Id));
        }

        var response = new RoleResponse(
            role.Id,
            role.Name,
            role.Description,
            role.Permissions.Select(p => p.Name).ToList(),
            role.Users.Select(u => new UserInRoleResponse(
                u.Id,
                u.Email,
                u.FirstName,
                u.LastName)).ToList());

        return response;
    }
}
