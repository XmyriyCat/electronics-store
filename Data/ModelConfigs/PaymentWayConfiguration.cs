using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigs
{
    public class PaymentWayConfiguration : IEntityTypeConfiguration<PaymentWay>
    {
        public void Configure(EntityTypeBuilder<PaymentWay> builder)
        {
            builder.ToTable("Payment_way");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        }
    }
}
