using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserPermissionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_permissions");

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
                    { new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"), "Create todos", "todos:create" },
                    { new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"), "Grant permissions", "permissions:grant" },
                    { new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"), "Assign roles to users", "roles:assign" },
                    { new Guid("3345e958-b730-4916-80e1-2428ed34c64f"), "Delete users", "users:delete" },
                    { new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"), "Create and modify roles", "roles:write" },
                    { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), "Access todos", "todos:access" },
                    { new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"), "Revoke permissions", "permissions:revoke" },
                    { new Guid("7623084a-b397-4b17-85ba-657054a3c68c"), "Read roles", "roles:read" },
                    { new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"), "Delete roles", "roles:delete" },
                    { new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"), "Update users", "users:update" },
                    { new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"), "Create users", "users:create" },
                    { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), "Access user information", "users:access" },
                    { new Guid("f5837cf7-8d37-421f-be7d-861349713243"), "Update todos", "todos:update" },
                    { new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"), "Delete todos", "todos:delete" },
                    { new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"), "Read permissions", "permissions:read" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b"), "Regular user role", "User" },
                    { new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b"), "Viewer role with read-only access", "Viewer" },
                    { new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56"), "Administrator role with full access", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "role_permissions",
                columns: new[] { "permissions_id", "roles_id" },
                values: new object[,]
                {
                    { new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") },
                    { new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("3345e958-b730-4916-80e1-2428ed34c64f"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") },
                    { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") },
                    { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("7623084a-b397-4b17-85ba-657054a3c68c"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") },
                    { new Guid("7623084a-b397-4b17-85ba-657054a3c68c"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") },
                    { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") },
                    { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("f5837cf7-8d37-421f-be7d-861349713243"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") },
                    { new Guid("f5837cf7-8d37-421f-be7d-861349713243"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") },
                    { new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") },
                    { new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") },
                    { new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("3345e958-b730-4916-80e1-2428ed34c64f"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("7623084a-b397-4b17-85ba-657054a3c68c"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("7623084a-b397-4b17-85ba-657054a3c68c"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("f5837cf7-8d37-421f-be7d-861349713243"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("f5837cf7-8d37-421f-be7d-861349713243"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"), new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"), new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b") });

            migrationBuilder.DeleteData(
                table: "role_permissions",
                keyColumns: new[] { "permissions_id", "roles_id" },
                keyValues: new object[] { new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"), new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56") });

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("3345e958-b730-4916-80e1-2428ed34c64f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("7623084a-b397-4b17-85ba-657054a3c68c"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("f5837cf7-8d37-421f-be7d-861349713243"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "id",
                keyValue: new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56"));

            migrationBuilder.CreateTable(
                name: "user_permissions",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    permission_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_permissions", x => new { x.user_id, x.permission_id });
                    table.ForeignKey(
                        name: "fk_user_permissions_permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_permissions_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "ix_user_permissions_permission_id",
                table: "user_permissions",
                column: "permission_id");
        }
    }
}
