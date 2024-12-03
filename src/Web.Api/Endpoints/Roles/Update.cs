using Application.Roles.Commands.UpdateRole;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;
using Web.Api.Endpoints.Users;

namespace Web.Api.Endpoints.Roles;

public class Update : IEndpoint
{
    public record UpdateRoleRequest(string Name, string Description);

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("roles/{roleId:guid}", async ([FromRoute] Guid roleId, [FromBody] UpdateRoleRequest request, ISender sender, CancellationToken cancellationToken) =>
        {
            var command = new UpdateRoleCommand(roleId, request.Name, request.Description);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesWrite)
        .WithTags(Tags.Roles)
        .WithName("UpdateRole")
        .Produces(StatusCodes.Status204NoContent)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
