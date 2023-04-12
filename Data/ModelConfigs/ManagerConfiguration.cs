using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");

            builder.HasIndex(e => e.Login, "Manager_login")
                .IsUnique();

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.HashPassword)
                .HasMaxLength(300)
                .HasColumnName("hash_password");

            builder.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");

            builder.Property(e => e.Salt)
                .HasMaxLength(100)
                .HasColumnName("salt");

            builder.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("user_name");
        }
    }
}
