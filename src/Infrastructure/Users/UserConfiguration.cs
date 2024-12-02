using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Users;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email)
            .HasColumnType("varchar(255)");

        builder.Property(u => u.FirstName)
            .HasColumnType("longtext");

        builder.Property(u => u.LastName)
            .HasColumnType("longtext");

        builder.Property(u => u.PasswordHash)
            .HasColumnType("longtext");

        builder.HasIndex(u => u.Email)
            .IsUnique();
    }
}
