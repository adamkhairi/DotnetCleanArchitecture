using Application.Roles.Commands.CreateRole;
using MediatR;
using SharedKernel;
using Web.Api.Endpoints.Users;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Roles;

public class Create : IEndpoint
{
    public sealed record CreateRoleRequest(string Name, string Description);

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("roles", async (CreateRoleRequest request, ISender sender, CancellationToken cancellationToken) =>
        {
            var command = new CreateRoleCommand(request.Name, request.Description);

            Result<Guid> result = await sender.Send(command, cancellationToken);

            return result.Match(
                id => Results.Created($"/roles/{id}", id),
                CustomResults.Problem);
        })
        .RequireAuthorization()
        .HasPermission(Permissions.RolesWrite)
        .WithTags(Tags.Roles)
        .WithName("CreateRole")
        .Produces<Guid>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
