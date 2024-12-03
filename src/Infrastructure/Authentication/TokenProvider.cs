using System.Security.Claims;
using System.Text;
using Application.Abstractions.Authentication;
using Domain.Roles;
using Domain.Users;
using Infrastructure.Authorization;
using Infrastructure.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Authentication;

internal sealed class TokenProvider : ITokenProvider
{
    private readonly IConfiguration _configuration;
    private readonly ApplicationDbContext _dbContext;

    public TokenProvider(IConfiguration configuration, ApplicationDbContext dbContext)
    {
        _configuration = configuration;
        _dbContext = dbContext;
    }

    public async Task<string> Create(User user)
    {
        string secretKey = _configuration["Jwt:Secret"]!;
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        // Get user roles and permissions
        User? userWithRoles = await _dbContext.Users
            .Include(u => u.Roles)
            .ThenInclude(r => r.Permissions)
            .FirstOrDefaultAsync(u => u.Id == user.Id)
            ?? throw new InvalidOperationException("User not found");

        List<Claim> claims = new()
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email),
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(JwtRegisteredClaimNames.GivenName, user.FirstName),
            new(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        // Add roles
        foreach (Role role in userWithRoles.Roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role.Name));
        }

        // Add permissions from roles
        IEnumerable<string> permissions = userWithRoles.Roles
            .SelectMany(r => r.Permissions)
            .Select(p => p.Name)
            .Distinct();

        foreach (string permission in permissions)
        {
            claims.Add(new Claim("permission", permission));
        }

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme),
            Expires = DateTime.UtcNow.AddMinutes(_configuration.GetValue<int>("Jwt:ExpirationInMinutes")),
            SigningCredentials = credentials,
            Issuer = _configuration["Jwt:Issuer"],
            Audience = _configuration["Jwt:Audience"]
        };

        var handler = new JsonWebTokenHandler();
        return handler.CreateToken(tokenDescriptor);
    }
}
