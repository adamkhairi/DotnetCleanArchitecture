using Application.Roles.Queries.GetRoles;
using MediatR;
using SharedKernel;
using Web.Api.Endpoints.Users;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Roles;

public class Get : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("roles", async (ISender sender, CancellationToken cancellationToken) =>
        {
            var query = new GetRolesQuery();

            Result<IReadOnlyList<RoleResponse>> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesRead)
        .WithTags(Tags.Roles)
        .WithName("GetRoles")
        .Produces<IReadOnlyList<RoleResponse>>()
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
