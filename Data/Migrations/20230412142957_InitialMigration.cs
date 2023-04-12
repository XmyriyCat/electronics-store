using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cost = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    hash_password = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    salt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payment_way",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_way", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    work_schedule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    id_category = table.Column<int>(type: "int", nullable: false),
                    id_manufacturer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.id_category,
                        principalTable: "Category",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer",
                        column: x => x.id_manufacturer,
                        principalTable: "Manufacturer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    cost = table.Column<double>(type: "float", nullable: false),
                    id_warehouse = table.Column<int>(type: "int", nullable: false),
                    id_payment_way = table.Column<int>(type: "int", nullable: false),
                    id_delivery = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shipment_Delivery",
                        column: x => x.id_delivery,
                        principalTable: "Delivery",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Shipment_Payment_way",
                        column: x => x.id_payment_way,
                        principalTable: "Payment_way",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Shipment_Warehouse",
                        column: x => x.id_warehouse,
                        principalTable: "Warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Picture_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_product = table.Column<int>(type: "int", nullable: false),
                    picture_position = table.Column<int>(type: "int", nullable: false),
                    picture_path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture_product", x => x.id);
                    table.ForeignKey(
                        name: "FK_Picture_product_Product",
                        column: x => x.id_product,
                        principalTable: "Product",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Ordered_products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    id_product = table.Column<int>(type: "int", nullable: false),
                    id_shipment = table.Column<int>(type: "int", nullable: false),
                    id_customer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordered_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ordered_products_Product",
                        column: x => x.id_customer,
                        principalTable: "Customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ordered_products_Product1",
                        column: x => x.id_product,
                        principalTable: "Product",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ordered_products_Shipment",
                        column: x => x.id_shipment,
                        principalTable: "Shipment",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "Manager_login",
                table: "Manager",
                column: "login",
                unique: true,
                filter: "[login] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_products_id_customer",
                table: "Ordered_products",
                column: "id_customer");

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_products_id_product",
                table: "Ordered_products",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_products_id_shipment",
                table: "Ordered_products",
                column: "id_shipment");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_product_id_product",
                table: "Picture_product",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_category",
                table: "Product",
                column: "id_category");

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_manufacturer",
                table: "Product",
                column: "id_manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_id_delivery",
                table: "Shipment",
                column: "id_delivery");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_id_payment_way",
                table: "Shipment",
                column: "id_payment_way");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_id_warehouse",
                table: "Shipment",
                column: "id_warehouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Ordered_products");

            migrationBuilder.DropTable(
                name: "Picture_product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Payment_way");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}
