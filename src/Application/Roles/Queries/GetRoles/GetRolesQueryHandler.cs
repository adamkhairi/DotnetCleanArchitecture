using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Application.Roles.Queries.GetRoles;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Roles.Queries.GetRoles;

internal sealed class GetRolesQueryHandler : IQueryHandler<GetRolesQuery, IReadOnlyList<RoleResponse>>
{
    private readonly IApplicationDbContext _context;

    public GetRolesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<IReadOnlyList<RoleResponse>>> Handle(GetRolesQuery query, CancellationToken cancellationToken)
    {
        List<RoleResponse> roles = await _context.Roles
            .Include(r => r.Permissions)
            .Include(r => r.Users)
            .Select(r => new RoleResponse(
                r.Id,
                r.Name,
                r.Description,
                r.Users.Count,
                r.Permissions.Count))
            .ToListAsync(cancellationToken);

        return Result.Success<IReadOnlyList<RoleResponse>>(roles);
    }
}
