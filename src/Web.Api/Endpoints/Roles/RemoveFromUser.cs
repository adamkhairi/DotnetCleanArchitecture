using Application.Roles.Commands.RemoveRoleFromUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;
using Web.Api.Endpoints.Users;

namespace Web.Api.Endpoints.Roles;

public class RemoveFromUser : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("roles/{roleId:guid}/users", async ([FromRoute] Guid roleId, [FromBody] RemoveFromUserRequest request, ISender sender, CancellationToken cancellationToken) =>
        {
            var command = new RemoveRoleFromUserCommand(roleId, request.UserId);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesWrite)
        .WithTags(Tags.Roles)
        .WithName("RemoveRoleFromUser")
        .Produces(StatusCodes.Status204NoContent)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
