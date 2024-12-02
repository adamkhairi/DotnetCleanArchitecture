using Application.Todos.Create;
using Domain.Todos;
using MediatR;
using Newtonsoft.Json;
using SharedKernel;
using Web.Api.Endpoints.Users;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Todos;

internal sealed class Create : IEndpoint
{
    public sealed class Request
    {
        public Guid UserId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }
        public List<string> Labels { get; set; } = [];
        public int Priority { get; set; }
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("todos", async (Request request, ISender sender, CancellationToken cancellationToken) =>
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Description))
                {
                    return Results.BadRequest("Description is required");
                }

                if (request.Labels?.Any(l => string.IsNullOrWhiteSpace(l)) == true)
                {
                    return Results.BadRequest("Labels cannot be empty strings");
                }

                if (!Enum.IsDefined(typeof(Priority), request.Priority))
                {
                    return Results.BadRequest($"Invalid priority value: {request.Priority}");
                }

                var command = new CreateTodoCommand
                {
                    UserId = request.UserId,
                    Description = request.Description,
                    DueDate = request.DueDate,
                    Labels = request.Labels ?? [],
                    Priority = (Priority)request.Priority
                };

                Result<Guid> result = await sender.Send(command, cancellationToken);

                return result.Match(
                    id => Results.Created($"/todos/{id}", id),
                    error => CustomResults.Problem(error));
            }
            catch (JsonException ex)
            {
                return Results.BadRequest(new { error = "Invalid JSON format", details = ex.Message });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        })
        .RequireAuthorization()
        .HasPermission(Permissions.TodosWrite)
        .WithTags(Tags.Todos)
        .WithName("CreateTodo")
        .Produces<Guid>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .ProducesProblem(StatusCodes.Status403Forbidden);
    }
}
