using Application.Abstractions.Data;
using Domain.Todos;
using Domain.Users;
using Domain.Permissions;
using Domain.Roles;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Infrastructure.Database;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPublisher publisher)
    : DbContext(options), IApplicationDbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<TodoItem> TodoItems { get; set; }

    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Only set default schema for PostgreSQL
        if (Database.ProviderName != "Pomelo.EntityFrameworkCore.MySql")
        {
            modelBuilder.HasDefaultSchema(Schemas.Default);
        }

        // Create permissions
        // User permissions
        var usersAccessPerm = Permission.Create("users:access", "Access user information");
        var usersCreatePerm = Permission.Create("users:create", "Create users");
        var usersUpdatePerm = Permission.Create("users:update", "Update users");
        var usersDeletePerm = Permission.Create("users:delete", "Delete users");

        // Todo permissions
        var todosAccessPerm = Permission.Create("todos:access", "Access todos");
        var todosCreatePerm = Permission.Create("todos:create", "Create todos");
        var todosUpdatePerm = Permission.Create("todos:update", "Update todos");
        var todosDeletePerm = Permission.Create("todos:delete", "Delete todos");

        // Role permissions
        var rolesReadPerm = Permission.Create("roles:read", "Read roles");
        var rolesWritePerm = Permission.Create("roles:write", "Create and modify roles");
        var rolesDeletePerm = Permission.Create("roles:delete", "Delete roles");
        var rolesAssignPerm = Permission.Create("roles:assign", "Assign roles to users");

        // Permission management
        var permissionsReadPerm = Permission.Create("permissions:read", "Read permissions");
        var permissionsGrantPerm = Permission.Create("permissions:grant", "Grant permissions");
        var permissionsRevokePerm = Permission.Create("permissions:revoke", "Revoke permissions");

        // Create roles
        var adminRole = Role.Create("Admin", "Administrator role with full access");
        var viewerRole = Role.Create("Viewer", "Viewer role with read-only access");
        var userRole = Role.Create("User", "Regular user role");

        // Seed permissions
        modelBuilder.Entity<Permission>().HasData(
            // User permissions
            usersAccessPerm,
            usersCreatePerm,
            usersUpdatePerm,
            usersDeletePerm,
            // Todo permissions
            todosAccessPerm,
            todosCreatePerm,
            todosUpdatePerm,
            todosDeletePerm,
            // Role permissions
            rolesReadPerm,
            rolesWritePerm,
            rolesDeletePerm,
            rolesAssignPerm,
            // Permission management
            permissionsReadPerm,
            permissionsGrantPerm,
            permissionsRevokePerm
        );

        // Seed roles
        modelBuilder.Entity<Role>().HasData(
            adminRole,
            viewerRole,
            userRole
        );

        // Seed role permissions
        modelBuilder.Entity("PermissionRole").HasData(
            // Admin role permissions - gets all permissions
            new { PermissionsId = usersAccessPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = usersCreatePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = usersUpdatePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = usersDeletePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = todosAccessPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = todosCreatePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = todosUpdatePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = todosDeletePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = rolesReadPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = rolesWritePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = rolesDeletePerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = rolesAssignPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = permissionsReadPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = permissionsGrantPerm.Id, RolesId = adminRole.Id },
            new { PermissionsId = permissionsRevokePerm.Id, RolesId = adminRole.Id },

            // Viewer role permissions - only read access
            new { PermissionsId = usersAccessPerm.Id, RolesId = viewerRole.Id },
            new { PermissionsId = todosAccessPerm.Id, RolesId = viewerRole.Id },
            new { PermissionsId = rolesReadPerm.Id, RolesId = viewerRole.Id },
            new { PermissionsId = permissionsReadPerm.Id, RolesId = viewerRole.Id },

            // Regular user role permissions
            new { PermissionsId = usersAccessPerm.Id, RolesId = userRole.Id },
            new { PermissionsId = todosAccessPerm.Id, RolesId = userRole.Id },
            new { PermissionsId = todosCreatePerm.Id, RolesId = userRole.Id },
            new { PermissionsId = todosUpdatePerm.Id, RolesId = userRole.Id },
            new { PermissionsId = todosDeletePerm.Id, RolesId = userRole.Id }
        );
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        int result = await base.SaveChangesAsync(cancellationToken);
        await PublishDomainEventsAsync();
        return result;
    }

    private async Task PublishDomainEventsAsync()
    {
        var domainEvents = ChangeTracker
            .Entries<Entity>()
            .Select(entry => entry.Entity)
            .SelectMany(entity =>
            {
                List<IDomainEvent> domainEvents = entity.DomainEvents;
                entity.ClearDomainEvents();
                return domainEvents;
            })
            .ToList();

        foreach (IDomainEvent domainEvent in domainEvents)
        {
            await publisher.Publish(domainEvent);
        }
    }
}
