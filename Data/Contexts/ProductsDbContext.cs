using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (this.Database.GetPendingMigrations().Any())
            {
                this.Database.Migrate();
            }
        }

        public virtual DbSet<Category> Categories { get => this.Set<Category>(); }

        public virtual DbSet<Customer> Customers { get => this.Set<Customer>(); }

        public virtual DbSet<Delivery> Deliveries { get => this.Set<Delivery>(); }

        public virtual DbSet<Manager> Managers { get => this.Set<Manager>(); }

        public virtual DbSet<Manufacturer> Manufacturers { get => this.Set<Manufacturer>(); }

        public virtual DbSet<OrderedProduct> OrderedProducts { get => this.Set<OrderedProduct>(); }

        public virtual DbSet<PaymentWay> PaymentWays { get => this.Set<PaymentWay>(); }

        public virtual DbSet<PictureProduct> PictureProducts { get => this.Set<PictureProduct>(); }

        public virtual DbSet<Product> Products { get => this.Set<Product>(); }

        public virtual DbSet<Shipment> Shipments { get => this.Set<Shipment>(); }

        public virtual DbSet<Warehouse> Warehouses { get => this.Set<Warehouse>(); }
    }
}
