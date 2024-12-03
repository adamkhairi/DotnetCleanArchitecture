using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations;

/// <inheritdoc />
public partial class UpdateAllTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
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

        migrationBuilder.AddColumn<DateTime>(
            name: "created_at",
            table: "users",
            type: "datetime(6)",
            nullable: false,
            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.AddColumn<DateTime>(
            name: "updated_at",
            table: "users",
            type: "datetime(6)",
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            name: "updated_at",
            table: "todo_items",
            type: "datetime(6)",
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            name: "created_at",
            table: "roles",
            type: "datetime(6)",
            nullable: false,
            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        migrationBuilder.AddColumn<DateTime>(
            name: "updated_at",
            table: "roles",
            type: "datetime(6)",
            nullable: true);

        migrationBuilder.InsertData(
            table: "permissions",
            columns: new[] { "id", "description", "name" },
            values: new object[,]
            {
                { new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"), "Create users", "users:create" },
                { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), "Access todos", "todos:access" },
                { new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"), "Update todos", "todos:update" },
                { new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"), "Delete roles", "roles:delete" },
                { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), "Access user information", "users:access" },
                { new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"), "Read roles", "roles:read" },
                { new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"), "Create and modify roles", "roles:write" },
                { new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"), "Delete users", "users:delete" },
                { new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"), "Create todos", "todos:create" },
                { new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"), "Grant permissions", "permissions:grant" },
                { new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"), "Update users", "users:update" },
                { new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"), "Delete todos", "todos:delete" },
                { new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"), "Assign roles to users", "roles:assign" },
                { new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"), "Read permissions", "permissions:read" },
                { new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"), "Revoke permissions", "permissions:revoke" }
            });

        migrationBuilder.InsertData(
            table: "roles",
            columns: new[] { "id", "created_at", "description", "name", "updated_at" },
            values: new object[,]
            {
                { new Guid("97274564-76f1-4a05-90df-5795470f5c49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular user role", "User", null },
                { new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator role with full access", "Admin", null },
                { new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viewer role with read-only access", "Viewer", null }
            });

        migrationBuilder.InsertData(
            table: "role_permissions",
            columns: new[] { "permissions_id", "roles_id" },
            values: new object[,]
            {
                { new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") },
                { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") },
                { new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") },
                { new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") },
                { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") },
                { new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") },
                { new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") },
                { new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") },
                { new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") },
                { new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") },
                { new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"), new Guid("97274564-76f1-4a05-90df-5795470f5c49") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"), new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e") });

        migrationBuilder.DeleteData(
            table: "role_permissions",
            keyColumns: new[] { "permissions_id", "roles_id" },
            keyValues: new object[] { new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"), new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246") });

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"));

        migrationBuilder.DeleteData(
            table: "permissions",
            keyColumn: "id",
            keyValue: new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"));

        migrationBuilder.DeleteData(
            table: "roles",
            keyColumn: "id",
            keyValue: new Guid("97274564-76f1-4a05-90df-5795470f5c49"));

        migrationBuilder.DeleteData(
            table: "roles",
            keyColumn: "id",
            keyValue: new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246"));

        migrationBuilder.DeleteData(
            table: "roles",
            keyColumn: "id",
            keyValue: new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e"));

        migrationBuilder.DropColumn(
            name: "created_at",
            table: "users");

        migrationBuilder.DropColumn(
            name: "updated_at",
            table: "users");

        migrationBuilder.DropColumn(
            name: "updated_at",
            table: "todo_items");

        migrationBuilder.DropColumn(
            name: "created_at",
            table: "roles");

        migrationBuilder.DropColumn(
            name: "updated_at",
            table: "roles");

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
}
