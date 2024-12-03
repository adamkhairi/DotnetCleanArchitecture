using Application.Roles.Commands.DeleteRole;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;
using Web.Api.Endpoints.Users;

namespace Web.Api.Endpoints.Roles;

public class Delete : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("roles/{roleId:guid}", async ([FromRoute] Guid roleId, ISender sender, CancellationToken cancellationToken) =>
        {
            var command = new DeleteRoleCommand(roleId);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesWrite)
        .WithTags(Tags.Roles)
        .WithName("DeleteRole")
        .Produces(StatusCodes.Status204NoContent)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
