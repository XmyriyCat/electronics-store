﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DomainModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("DomainModels.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("name")
                        .IsFixedLength();

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DomainModels.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Cost")
                        .HasColumnType("float")
                        .HasColumnName("cost");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Delivery", (string)null);
                });

            modelBuilder.Entity("DomainModels.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HashPassword")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("hash_password");

                    b.Property<string>("Login")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("login");

                    b.Property<string>("Salt")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("salt");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Login" }, "Manager_login")
                        .IsUnique()
                        .HasFilter("[login] IS NOT NULL");

                    b.ToTable("Manager", (string)null);
                });

            modelBuilder.Entity("DomainModels.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer", (string)null);
                });

            modelBuilder.Entity("DomainModels.OrderedProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int")
                        .HasColumnName("id_customer");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("id_product");

                    b.Property<int>("IdShipment")
                        .HasColumnType("int")
                        .HasColumnName("id_shipment");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdShipment");

                    b.ToTable("Ordered_products", (string)null);
                });

            modelBuilder.Entity("DomainModels.PaymentWay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Payment_way", (string)null);
                });

            modelBuilder.Entity("DomainModels.PictureProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("id_product");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("picture_path");

                    b.Property<int>("PicturePosition")
                        .HasColumnType("int")
                        .HasColumnName("picture_position");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.ToTable("Picture_product", (string)null);
                });

            modelBuilder.Entity("DomainModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasColumnName("description");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int")
                        .HasColumnName("id_category");

                    b.Property<int>("IdManufacturer")
                        .HasColumnType("int")
                        .HasColumnName("id_manufacturer");

                    b.Property<string>("Model")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("model");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdManufacturer");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DomainModels.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Cost")
                        .HasColumnType("float")
                        .HasColumnName("cost");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int>("IdDelivery")
                        .HasColumnType("int")
                        .HasColumnName("id_delivery");

                    b.Property<int>("IdPaymentWay")
                        .HasColumnType("int")
                        .HasColumnName("id_payment_way");

                    b.Property<int>("IdWarehouse")
                        .HasColumnType("int")
                        .HasColumnName("id_warehouse");

                    b.HasKey("Id");

                    b.HasIndex("IdDelivery");

                    b.HasIndex("IdPaymentWay");

                    b.HasIndex("IdWarehouse");

                    b.ToTable("Shipment", (string)null);
                });

            modelBuilder.Entity("DomainModels.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone_number");

                    b.Property<string>("WorkSchedule")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("work_schedule");

                    b.HasKey("Id")
                        .HasName("PK_warehouse");

                    b.ToTable("Warehouse", (string)null);
                });

            modelBuilder.Entity("DomainModels.OrderedProduct", b =>
                {
                    b.HasOne("DomainModels.Customer", "IdCustomerNavigation")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("IdCustomer")
                        .IsRequired()
                        .HasConstraintName("FK_Ordered_products_Product");

                    b.HasOne("DomainModels.Product", "IdProductNavigation")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("IdProduct")
                        .IsRequired()
                        .HasConstraintName("FK_Ordered_products_Product1");

                    b.HasOne("DomainModels.Shipment", "IdShipmentNavigation")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("IdShipment")
                        .IsRequired()
                        .HasConstraintName("FK_Ordered_products_Shipment");

                    b.Navigation("IdCustomerNavigation");

                    b.Navigation("IdProductNavigation");

                    b.Navigation("IdShipmentNavigation");
                });

            modelBuilder.Entity("DomainModels.PictureProduct", b =>
                {
                    b.HasOne("DomainModels.Product", "IdProductNavigation")
                        .WithMany("PictureProducts")
                        .HasForeignKey("IdProduct")
                        .IsRequired()
                        .HasConstraintName("FK_Picture_product_Product");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("DomainModels.Product", b =>
                {
                    b.HasOne("DomainModels.Category", "IdCategoryNavigation")
                        .WithMany("Products")
                        .HasForeignKey("IdCategory")
                        .IsRequired()
                        .HasConstraintName("FK_Product_Category");

                    b.HasOne("DomainModels.Manufacturer", "IdManufacturerNavigation")
                        .WithMany("Products")
                        .HasForeignKey("IdManufacturer")
                        .IsRequired()
                        .HasConstraintName("FK_Product_Manufacturer");

                    b.Navigation("IdCategoryNavigation");

                    b.Navigation("IdManufacturerNavigation");
                });

            modelBuilder.Entity("DomainModels.Shipment", b =>
                {
                    b.HasOne("DomainModels.Delivery", "IdDeliveryNavigation")
                        .WithMany("Shipments")
                        .HasForeignKey("IdDelivery")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Delivery");

                    b.HasOne("DomainModels.PaymentWay", "IdPaymentWayNavigation")
                        .WithMany("Shipments")
                        .HasForeignKey("IdPaymentWay")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Payment_way");

                    b.HasOne("DomainModels.Warehouse", "IdWarehouseNavigation")
                        .WithMany("Shipments")
                        .HasForeignKey("IdWarehouse")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Warehouse");

                    b.Navigation("IdDeliveryNavigation");

                    b.Navigation("IdPaymentWayNavigation");

                    b.Navigation("IdWarehouseNavigation");
                });

            modelBuilder.Entity("DomainModels.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DomainModels.Customer", b =>
                {
                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("DomainModels.Delivery", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("DomainModels.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DomainModels.PaymentWay", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("DomainModels.Product", b =>
                {
                    b.Navigation("OrderedProducts");

                    b.Navigation("PictureProducts");
                });

            modelBuilder.Entity("DomainModels.Shipment", b =>
                {
                    b.Navigation("OrderedProducts");
                });

            modelBuilder.Entity("DomainModels.Warehouse", b =>
                {
                    b.Navigation("Shipments");
                });
#pragma warning restore 612, 618
        }
    }
}