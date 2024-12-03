using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePermissionsAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("01732287-b3b0-47fd-935f-9ae8a4ccbe0d"), "Assign roles to users", "roles:assign" },
                    { new Guid("122ccd43-5714-4d28-8710-87b07dbab217"), "Delete roles", "roles:delete" },
                    { new Guid("48547579-ac7e-453c-88c1-d9664f44c499"), "Grant permissions", "permissions:grant" },
                    { new Guid("4a60a5f3-e685-416f-9c99-10c39f031781"), "Update users", "users:update" },
                    { new Guid("535f24e5-e504-424c-bb4e-81c269f67dec"), "Create users", "users:create" },
                    { new Guid("5c744dec-50a5-4741-97ce-7ed0d4feec56"), "Delete users", "users:delete" },
                    { new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"), "Delete todos", "todos:delete" },
                    { new Guid("7671eade-590d-45a0-b974-784c8420094f"), "Create and modify roles", "roles:write" },
                    { new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"), "Read permissions", "permissions:read" },
                    { new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"), "Read roles", "roles:read" },
                    { new Guid("a43e2b4a-fc03-45d2-ad63-bb96d3fbecfd"), "Revoke permissions", "permissions:revoke" },
                    { new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"), "Update todos", "todos:update" },
                    { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), "Access user information", "users:access" },
                    { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), "Access todos", "todos:access" },
                    { new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"), "Create todos", "todos:create" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0"), "Regular user role", "User" },
                    { new Guid("c1e99be1-fcae-4581-a31e-064f29d94038"), "Viewer role with read-only access", "Viewer" },
                    { new Guid("d5451540-cc26-49ce-8456-ac649c57d387"), "Administrator role with full access", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "role_permissions",
                columns: new[] { "permissions_id", "roles_id" },
                values: new object[,]
                {
                    { new Guid("01732287-b3b0-47fd-935f-9ae8a4ccbe0d"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("122ccd43-5714-4d28-8710-87b07dbab217"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("48547579-ac7e-453c-88c1-d9664f44c499"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("4a60a5f3-e685-416f-9c99-10c39f031781"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("535f24e5-e504-424c-bb4e-81c269f67dec"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("5c744dec-50a5-4741-97ce-7ed0d4feec56"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") },
                    { new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("7671eade-590d-45a0-b974-784c8420094f"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") },
                    { new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") },
                    { new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("a43e2b4a-fc03-45d2-ad63-bb96d3fbecfd"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") },
                    { new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") },
                    { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") },
                    { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") },
                    { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") },
                    { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") },
                    { new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") },
                    { new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("01732287-b3b0-47fd-935f-9ae8a4ccbe0d"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("122ccd43-5714-4d28-8710-87b07dbab217"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("48547579-ac7e-453c-88c1-d9664f44c499"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("4a60a5f3-e685-416f-9c99-10c39f031781"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("535f24e5-e504-424c-bb4e-81c269f67dec"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("5c744dec-50a5-4741-97ce-7ed0d4feec56"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("7671eade-590d-45a0-b974-784c8420094f"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("a43e2b4a-fc03-45d2-ad63-bb96d3fbecfd"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("c1e99be1-fcae-4581-a31e-064f29d94038") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"), new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"), new Guid("d5451540-cc26-49ce-8456-ac649c57d387") });

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("01732287-b3b0-47fd-935f-9ae8a4ccbe0d"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("122ccd43-5714-4d28-8710-87b07dbab217"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("48547579-ac7e-453c-88c1-d9664f44c499"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("4a60a5f3-e685-416f-9c99-10c39f031781"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("535f24e5-e504-424c-bb4e-81c269f67dec"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("5c744dec-50a5-4741-97ce-7ed0d4feec56"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("745368b3-e73d-4e30-af4b-0769f05f0206"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("7671eade-590d-45a0-b974-784c8420094f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("8b6be42a-4ac2-48a1-baca-cc9c6a40a5d6"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("962efce7-fd30-4b15-ab1f-b807c109fc8d"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("a43e2b4a-fc03-45d2-ad63-bb96d3fbecfd"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("aa9eac9c-a1be-44fb-b3f2-9d8e5f4fa98e"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("aee2f4b2-5bb8-4947-981a-97bca94e8a57"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("e5afbca2-ec03-4f45-bb3b-692b41eeff3f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("ed624861-d9b1-452b-b0d0-d8c4c8f727da"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("8d398087-6e41-4aeb-aa0d-a8ea5d2265e0"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("c1e99be1-fcae-4581-a31e-064f29d94038"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("d5451540-cc26-49ce-8456-ac649c57d387"));

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
    }
}
