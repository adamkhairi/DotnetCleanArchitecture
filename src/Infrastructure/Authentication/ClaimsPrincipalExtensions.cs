using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using System;

namespace Infrastructure.Authentication;

internal static class ClaimsPrincipalExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal? principal)
    {
        if (principal == null)
        {
            throw new ApplicationException("User is not authenticated");
        }

        // Debug: Log all claims
        var claims = principal.Claims.Select(c => $"{c.Type}: {c.Value}").ToList();
        Console.WriteLine("Available claims: " + string.Join(", ", claims));

        string? userId = principal.FindFirstValue(JwtRegisteredClaimNames.Sub) ?? 
                        principal.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
        {
            throw new ApplicationException($"User id claim is missing. Available claims: {string.Join(", ", claims)}");
        }

        if (!Guid.TryParse(userId, out Guid parsedUserId))
        {
            throw new ApplicationException($"Invalid user id format: {userId}");
        }

        return parsedUserId;
    }
}
