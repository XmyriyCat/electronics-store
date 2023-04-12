using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Description)
                .HasMaxLength(550)
                .HasColumnName("description");

            builder.Property(e => e.IdCategory)
                .HasColumnName("id_category");

            builder.Property(e => e.IdManufacturer)
                .HasColumnName("id_manufacturer");

            builder.Property(e => e.Model)
                .HasMaxLength(150)
                .HasColumnName("model");

            builder.Property(e => e.Price)
                .HasColumnName("price");

            builder.Property(e => e.Quantity)
                .HasColumnName("quantity");

            builder.HasOne(d => d.IdCategoryNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");

            builder.HasOne(d => d.IdManufacturerNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Manufacturer");
        }
    }
}
