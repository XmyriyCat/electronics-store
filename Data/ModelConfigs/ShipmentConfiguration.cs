using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.ToTable("Shipment");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Cost)
                .HasColumnName("cost");

            builder.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");

            builder.Property(e => e.IdDelivery)
                .HasColumnName("id_delivery");

            builder.Property(e => e.IdPaymentWay)
                .HasColumnName("id_payment_way");

            builder.Property(e => e.IdWarehouse)
                .HasColumnName("id_warehouse");
            
            builder.HasOne(d => d.IdDeliveryNavigation)
                .WithMany(p => p.Shipments)
                .HasForeignKey(d => d.IdDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Delivery");

            builder.HasOne(d => d.IdPaymentWayNavigation)
                .WithMany(p => p.Shipments)
                .HasForeignKey(d => d.IdPaymentWay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Payment_way");

            builder.HasOne(d => d.IdWarehouseNavigation)
                .WithMany(p => p.Shipments)
                .HasForeignKey(d => d.IdWarehouse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Warehouse");
        }
    }
}
