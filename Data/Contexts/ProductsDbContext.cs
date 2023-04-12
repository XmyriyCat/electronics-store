using DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure all model configurations that implements interface IEntityTypeConfiguration<T> from Assembly
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<Category> Categories { get; }

        public virtual DbSet<Customer> Customers { get; }

        public virtual DbSet<Delivery> Deliveries { get ; }

        public virtual DbSet<Manager> Managers { get ; }

        public virtual DbSet<Manufacturer> Manufacturers { get ; }

        public virtual DbSet<OrderedProduct> OrderedProducts { get ; }

        public virtual DbSet<PaymentWay> PaymentWays { get ; }

        public virtual DbSet<PictureProduct> PictureProducts { get ; }

        public virtual DbSet<Product> Products { get ; }

        public virtual DbSet<Shipment> Shipments { get ; }

        public virtual DbSet<Warehouse> Warehouses { get ; }
    }
}
