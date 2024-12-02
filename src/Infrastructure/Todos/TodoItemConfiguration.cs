using Domain.Todos;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Todos;

internal sealed class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Labels)
            .HasColumnType("json");

        builder.Property(t => t.DueDate)
            .HasColumnType("datetime(6)")
            .HasConversion(
                d => d != null ? DateTime.SpecifyKind(d.Value, DateTimeKind.Utc) : d,
                v => v);

        builder.Property(t => t.CreatedAt)
            .HasColumnType("datetime(6)");

        builder.Property(t => t.CompletedAt)
            .HasColumnType("datetime(6)");

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(t => t.UserId);
    }
}
