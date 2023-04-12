using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouse");

            builder.HasKey(e => e.Id)
                .HasName("PK_warehouse");
            
            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            
            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            
            builder.Property(e => e.WorkSchedule)
                .HasMaxLength(50)
                .HasColumnName("work_schedule");
        }
    }
}
