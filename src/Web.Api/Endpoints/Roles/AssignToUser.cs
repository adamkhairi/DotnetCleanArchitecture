using Application.Roles.Commands.AssignRoleToUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Endpoints.Users;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Roles;

public class AssignToUser : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("roles/{roleId:guid}/users", async ([FromRoute] Guid roleId, [FromBody] AssignToUserRequest request, ISender sender, CancellationToken cancellationToken) =>
        {
            var command = new AssignRoleToUserCommand(roleId, request.UserId);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesWrite)
        .WithTags(Tags.Roles)
        .WithName("AssignRoleToUser")
        .Produces(StatusCodes.Status204NoContent)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
