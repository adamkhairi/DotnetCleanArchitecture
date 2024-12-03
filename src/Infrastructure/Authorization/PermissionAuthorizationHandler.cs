using Infrastructure.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Authorization;

internal sealed class PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory, ILogger<PermissionAuthorizationHandler> logger)
    : AuthorizationHandler<PermissionRequirement>
{
    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        PermissionRequirement requirement)
    {
        if (context.User?.Identity?.IsAuthenticated != true)
        {
            logger.LogWarning("User is not authenticated.");
            context.Fail();
            return;
        }

        using IServiceScope scope = serviceScopeFactory.CreateScope();
        PermissionProvider permissionProvider = scope.ServiceProvider.GetRequiredService<PermissionProvider>();
        
        try
        {
            Guid userId = context.User.GetUserId();
            bool hasPermission = await permissionProvider.UserHasPermissionAsync(userId, requirement.Permission);

            if (hasPermission)
            {
                logger.LogInformation("User {UserId} has permission {Permission}.", userId, requirement.Permission);
                context.Succeed(requirement);
                return;
            }

            logger.LogWarning("User {UserId} does not have permission {Permission}.", userId, requirement.Permission);
            context.Fail();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error checking permission {Permission} for user {UserId}.", requirement.Permission, context.User.GetUserId());
            context.Fail();
        }
    }
}
