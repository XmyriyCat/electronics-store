using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class PictureProductConfiguration : IEntityTypeConfiguration<PictureProduct>
    {
        public void Configure(EntityTypeBuilder<PictureProduct> builder)
        {
            builder.ToTable("Picture_product");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.IdProduct)
                .HasColumnName("id_product");

            builder.Property(e => e.PicturePath)
                .HasColumnName("picture_path");

            builder.Property(e => e.PicturePosition)
                .HasColumnName("picture_position");
            
            builder.HasOne(d => d.IdProductNavigation)
                .WithMany(p => p.PictureProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Picture_product_Product");
        }
    }
}
