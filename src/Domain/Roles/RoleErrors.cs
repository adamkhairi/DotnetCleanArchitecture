using SharedKernel;

namespace Domain.Roles;

public static class RoleErrors
{
    public static Error NotFound(Guid roleId) => Error.NotFound(
        "Role.NotFound",
        $"The role with ID {roleId} was not found.");
}
