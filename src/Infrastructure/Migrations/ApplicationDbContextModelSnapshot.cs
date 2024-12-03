﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"),
                            Description = "Access user information",
                            Name = "users:access"
                        },
                        new
                        {
                            Id = new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"),
                            Description = "Create users",
                            Name = "users:create"
                        },
                        new
                        {
                            Id = new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"),
                            Description = "Update users",
                            Name = "users:update"
                        },
                        new
                        {
                            Id = new Guid("3345e958-b730-4916-80e1-2428ed34c64f"),
                            Description = "Delete users",
                            Name = "users:delete"
                        },
                        new
                        {
                            Id = new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"),
                            Description = "Access todos",
                            Name = "todos:access"
                        },
                        new
                        {
                            Id = new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"),
                            Description = "Create todos",
                            Name = "todos:create"
                        },
                        new
                        {
                            Id = new Guid("f5837cf7-8d37-421f-be7d-861349713243"),
                            Description = "Update todos",
                            Name = "todos:update"
                        },
                        new
                        {
                            Id = new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"),
                            Description = "Delete todos",
                            Name = "todos:delete"
                        },
                        new
                        {
                            Id = new Guid("7623084a-b397-4b17-85ba-657054a3c68c"),
                            Description = "Read roles",
                            Name = "roles:read"
                        },
                        new
                        {
                            Id = new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"),
                            Description = "Create and modify roles",
                            Name = "roles:write"
                        },
                        new
                        {
                            Id = new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"),
                            Description = "Delete roles",
                            Name = "roles:delete"
                        },
                        new
                        {
                            Id = new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"),
                            Description = "Assign roles to users",
                            Name = "roles:assign"
                        },
                        new
                        {
                            Id = new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"),
                            Description = "Read permissions",
                            Name = "permissions:read"
                        },
                        new
                        {
                            Id = new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"),
                            Description = "Grant permissions",
                            Name = "permissions:grant"
                        },
                        new
                        {
                            Id = new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"),
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
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56"),
                            Description = "Administrator role with full access",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b"),
                            Description = "Viewer role with read-only access",
                            Name = "Viewer"
                        },
                        new
                        {
                            Id = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b"),
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
                            PermissionsId = new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("cb880392-0630-45ff-996f-b4bba24c92ef"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("b52cadd0-07d9-4ffe-a377-5f88dee98fee"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("3345e958-b730-4916-80e1-2428ed34c64f"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("f5837cf7-8d37-421f-be7d-861349713243"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("7623084a-b397-4b17-85ba-657054a3c68c"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("649052f5-b348-4eb2-bd7c-599c9b1f34a2"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("a797fbc6-7626-4530-b235-ea4043c3fe79"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("321f0a55-8f77-4548-80e7-e27b0d0814aa"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("1709c2d0-5f8e-4896-a4fb-7a6dba1c962a"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("6c9e2640-4fe9-48e1-832d-0f55d73e5c95"),
                            RolesId = new Guid("ba4a46d5-0ef1-4037-9857-1d13a91b9e56")
                        },
                        new
                        {
                            PermissionsId = new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"),
                            RolesId = new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b")
                        },
                        new
                        {
                            PermissionsId = new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"),
                            RolesId = new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b")
                        },
                        new
                        {
                            PermissionsId = new Guid("7623084a-b397-4b17-85ba-657054a3c68c"),
                            RolesId = new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b")
                        },
                        new
                        {
                            PermissionsId = new Guid("ff0a3985-00c2-46ff-b96f-a80e3a2d95a4"),
                            RolesId = new Guid("644cb19d-9125-4c8e-a268-c1e2ab64b35b")
                        },
                        new
                        {
                            PermissionsId = new Guid("e54e7c3a-85c3-413e-81dc-267e4f2cfcf5"),
                            RolesId = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b")
                        },
                        new
                        {
                            PermissionsId = new Guid("687a271e-e463-4640-ad72-bd7fdfe7503b"),
                            RolesId = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b")
                        },
                        new
                        {
                            PermissionsId = new Guid("09b585b0-2050-45f8-aaa3-af88eb420640"),
                            RolesId = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b")
                        },
                        new
                        {
                            PermissionsId = new Guid("f5837cf7-8d37-421f-be7d-861349713243"),
                            RolesId = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b")
                        },
                        new
                        {
                            PermissionsId = new Guid("fcb5c47d-c643-40a8-b134-9031b78a69f9"),
                            RolesId = new Guid("5c0e87ba-4ca8-487f-a8f5-0c91c2a76c7b")
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
