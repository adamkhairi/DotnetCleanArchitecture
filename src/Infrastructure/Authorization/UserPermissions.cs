namespace Infrastructure.Authorization;

public static class UserPermissions
{
    public static class Users
    {
        public const string View = "Users.View";
        public const string Create = "Users.Create";
        public const string Update = "Users.Update";
        public const string Delete = "Users.Delete";
    }

    public static class Todos
    {
        public const string View = "Todos.View";
        public const string Create = "Todos.Create";
        public const string Update = "Todos.Update";
        public const string Delete = "Todos.Delete";
    }

    public static class Permissions
    {
        public const string View = "Permissions.View";
        public const string Grant = "Permissions.Grant";
        public const string Revoke = "Permissions.Revoke";
    }
}
