﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241203063851_UpdateAllTable")]
    partial class UpdateAllTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Domain.Permissions.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_permissions");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_permissions_name");

                    b.ToTable("permissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"),
                            Description = "Access user information",
                            Name = "users:access"
                        },
                        new
                        {
                            Id = new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"),
                            Description = "Create users",
                            Name = "users:create"
                        },
                        new
                        {
                            Id = new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"),
                            Description = "Update users",
                            Name = "users:update"
                        },
                        new
                        {
                            Id = new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"),
                            Description = "Delete users",
                            Name = "users:delete"
                        },
                        new
                        {
                            Id = new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"),
                            Description = "Access todos",
                            Name = "todos:access"
                        },
                        new
                        {
                            Id = new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"),
                            Description = "Create todos",
                            Name = "todos:create"
                        },
                        new
                        {
                            Id = new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"),
                            Description = "Update todos",
                            Name = "todos:update"
                        },
                        new
                        {
                            Id = new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"),
                            Description = "Delete todos",
                            Name = "todos:delete"
                        },
                        new
                        {
                            Id = new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"),
                            Description = "Read roles",
                            Name = "roles:read"
                        },
                        new
                        {
                            Id = new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"),
                            Description = "Create and modify roles",
                            Name = "roles:write"
                        },
                        new
                        {
                            Id = new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"),
                            Description = "Delete roles",
                            Name = "roles:delete"
                        },
                        new
                        {
                            Id = new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"),
                            Description = "Assign roles to users",
                            Name = "roles:assign"
                        },
                        new
                        {
                            Id = new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"),
                            Description = "Read permissions",
                            Name = "permissions:read"
                        },
                        new
                        {
                            Id = new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"),
                            Description = "Grant permissions",
                            Name = "permissions:grant"
                        },
                        new
                        {
                            Id = new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"),
                            Description = "Revoke permissions",
                            Name = "permissions:revoke"
                        });
                });

            modelBuilder.Entity("Domain.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Administrator role with full access",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Viewer role with read-only access",
                            Name = "Viewer"
                        },
                        new
                        {
                            Id = new Guid("97274564-76f1-4a05-90df-5795470f5c49"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Regular user role",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Domain.Todos.TodoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("completed_at");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("due_date");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_completed");

                    b.Property<string>("Labels")
                        .IsRequired()
                        .HasColumnType("json")
                        .HasColumnName("labels");

                    b.Property<int>("Priority")
                        .HasColumnType("int")
                        .HasColumnName("priority");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_todo_items");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_todo_items_user_id");

                    b.ToTable("todo_items", (string)null);
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password_hash");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<Guid>("PermissionsId")
                        .HasColumnType("char(36)")
                        .HasColumnName("permissions_id");

                    b.Property<Guid>("RolesId")
                        .HasColumnType("char(36)")
                        .HasColumnName("roles_id");

                    b.HasKey("PermissionsId", "RolesId")
                        .HasName("pk_role_permissions");

                    b.HasIndex("RolesId")
                        .HasDatabaseName("ix_role_permissions_roles_id");

                    b.ToTable("role_permissions", (string)null);

                    b.HasData(
                        new
                        {
                            PermissionsId = new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("35571ca0-8c64-4a86-9521-3b2822ad1664"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("b1c5d005-ea00-49b2-b983-8bcfa30f1b9a"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("957f47c0-236f-4959-bb28-0d6b981e0e5a"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("93a78f40-205a-4d2a-ab56-8e3cf1c4dacd"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("7addd5f0-f1a9-45b4-8b41-e68adc8892d5"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("c363f661-9b96-49ef-98d1-39033ef822bc"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("9cfbc6c7-93c7-41e7-adec-7451bd5ca9d1"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("e749d672-0f81-4dfb-82e7-562e571577f9"),
                            RolesId = new Guid("a10491d0-ba1c-4515-8a50-e5d70a006246")
                        },
                        new
                        {
                            PermissionsId = new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"),
                            RolesId = new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e")
                        },
                        new
                        {
                            PermissionsId = new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"),
                            RolesId = new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e")
                        },
                        new
                        {
                            PermissionsId = new Guid("908bdb8c-4769-449f-8960-7aff11f7f2f0"),
                            RolesId = new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e")
                        },
                        new
                        {
                            PermissionsId = new Guid("cbed63e7-77e6-4b16-be8d-25ab192844c6"),
                            RolesId = new Guid("e1190cf5-aeae-4e85-88df-c48869a7239e")
                        },
                        new
                        {
                            PermissionsId = new Guid("8ea2de2c-b039-4ae0-b6e4-139a977e77a7"),
                            RolesId = new Guid("97274564-76f1-4a05-90df-5795470f5c49")
                        },
                        new
                        {
                            PermissionsId = new Guid("6dd69420-db40-4acf-a169-7118381eb4b6"),
                            RolesId = new Guid("97274564-76f1-4a05-90df-5795470f5c49")
                        },
                        new
                        {
                            PermissionsId = new Guid("993d7628-57d4-4cd3-8915-a8d316198a01"),
                            RolesId = new Guid("97274564-76f1-4a05-90df-5795470f5c49")
                        },
                        new
                        {
                            PermissionsId = new Guid("780311f4-2373-458c-bbc6-cdafb749ca6c"),
                            RolesId = new Guid("97274564-76f1-4a05-90df-5795470f5c49")
                        },
                        new
                        {
                            PermissionsId = new Guid("b7f65910-612f-4214-aba5-ee1d1982884a"),
                            RolesId = new Guid("97274564-76f1-4a05-90df-5795470f5c49")
                        });
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("char(36)")
                        .HasColumnName("roles_id");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("char(36)")
                        .HasColumnName("users_id");

                    b.HasKey("RolesId", "UsersId")
                        .HasName("pk_user_roles");

                    b.HasIndex("UsersId")
                        .HasDatabaseName("ix_user_roles_users_id");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("Domain.Todos.TodoItem", b =>
                {
                    b.HasOne("Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_todo_items_users_user_id");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Domain.Permissions.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_permissions_permissions_permissions_id");

                    b.HasOne("Domain.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_permissions_roles_roles_id");
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.HasOne("Domain.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_roles_roles_id");

                    b.HasOne("Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_users_users_id");
                });
#pragma warning restore 612, 618
        }
    }
}
