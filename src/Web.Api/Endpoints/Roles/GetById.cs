using Application.Roles.Queries.GetRoleById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;
using Web.Api.Endpoints.Users;

namespace Web.Api.Endpoints.Roles;

public class GetById : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("roles/{roleId:guid}", async ([FromRoute] Guid roleId, ISender sender, CancellationToken cancellationToken) =>
        {
            var query = new GetRoleByIdQuery(roleId);

            Result<RoleResponse> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesRead)
        .WithTags(Tags.Roles)
        .WithName("GetRoleById")
        .Produces<RoleResponse>()
        .ProducesProblem(StatusCodes.Status404NotFound)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
