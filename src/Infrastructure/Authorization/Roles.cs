namespace Infrastructure.Authorization;

public static class Roles
{
    public static class Admin
    {
        public static readonly string[] Permissions =
        {
            UserPermissions.Users.View,
            UserPermissions.Users.Create,
            UserPermissions.Users.Update,
            UserPermissions.Users.Delete,
            UserPermissions.Todos.View,
            UserPermissions.Todos.Create,
            UserPermissions.Todos.Update,
            UserPermissions.Todos.Delete,
            UserPermissions.Permissions.View,
            UserPermissions.Permissions.Grant,
            UserPermissions.Permissions.Revoke
        };
    }

    public static class Viewer
    {
        public static readonly string[] Permissions =
        {
            UserPermissions.Users.View,
            UserPermissions.Todos.View,
            UserPermissions.Permissions.View
        };
    }
}
