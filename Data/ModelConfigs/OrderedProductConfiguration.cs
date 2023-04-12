using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class OrderedProductConfiguration : IEntityTypeConfiguration<OrderedProduct>
    {
        public void Configure(EntityTypeBuilder<OrderedProduct> builder)
        {
            builder.ToTable("Ordered_products");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");

            builder.Property(e => e.IdCustomer)
                .HasColumnName("id_customer");

            builder.Property(e => e.IdProduct)
                .HasColumnName("id_product");

            builder.Property(e => e.IdShipment)
                .HasColumnName("id_shipment");

            builder.Property(e => e.Quantity)
                .HasColumnName("quantity");
            
            builder.HasOne(d => d.IdCustomerNavigation)
                .WithMany(p => p.OrderedProducts)
                .HasForeignKey(d => d.IdCustomer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ordered_products_Product");

            builder.HasOne(d => d.IdProductNavigation)
                .WithMany(p => p.OrderedProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ordered_products_Product1");

            builder.HasOne(d => d.IdShipmentNavigation)
                .WithMany(p => p.OrderedProducts)
                .HasForeignKey(d => d.IdShipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ordered_products_Shipment");
        }
    }
}
