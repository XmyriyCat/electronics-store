using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Delivery");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Cost)
                .HasColumnName("cost");

            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        }
    }
}
