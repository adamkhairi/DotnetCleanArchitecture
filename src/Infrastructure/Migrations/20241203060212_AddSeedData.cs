using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("3e75579c-2f7f-44a7-9605-0323033fcf3e"), "Create and modify roles", "roles:write" },
                    { new Guid("60761be2-bce8-4f52-82b5-06913241f617"), "Create and modify todos", "todos:write" },
                    { new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"), "Access todos", "todos:access" },
                    { new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"), "Access user information", "users:access" },
                    { new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"), "Read roles", "roles:read" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221"), "Viewer role with read-only access", "Viewer" },
                    { new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe"), "Administrator role with full access", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "role_permissions",
                columns: new[] { "permissions_id", "roles_id" },
                values: new object[,]
                {
                    { new Guid("3e75579c-2f7f-44a7-9605-0323033fcf3e"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") },
                    { new Guid("60761be2-bce8-4f52-82b5-06913241f617"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") },
                    { new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") },
                    { new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") },
                    { new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") },
                    { new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") },
                    { new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") },
                    { new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("3e75579c-2f7f-44a7-9605-0323033fcf3e"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("60761be2-bce8-4f52-82b5-06913241f617"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"), new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"), new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe") });

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("3e75579c-2f7f-44a7-9605-0323033fcf3e"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("60761be2-bce8-4f52-82b5-06913241f617"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("6bf16684-dc1b-48ca-8af1-357db9f3c019"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("c06ff241-3b93-4b8c-ab3f-c2235b620f11"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("e783d7dc-cae0-4541-aa82-dcd1ca4566e5"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("850837ff-b4d0-4dcc-bead-a8bd5a261221"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("db11660e-5d38-41e2-ac8a-58dcd818ecfe"));
        }
    }
}
