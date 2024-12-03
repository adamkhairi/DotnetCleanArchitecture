using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Endpoints.Roles;

public sealed class AssignToUserRequest
{
    public required Guid UserId { get; init; }
}
