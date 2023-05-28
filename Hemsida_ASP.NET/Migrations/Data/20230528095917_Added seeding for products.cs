using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hemsida_ASP.NET.Migrations.Data
{
    /// <inheritdoc />
    public partial class Addedseedingforproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleId", "Description", "Ingress", "Price", "ProductImage", "ProductName", "VendorName" },
                values: new object[,]
                {
                    { "A12395B", "These running shoes are designed for optimal performance and comfort. With a lightweight and breathable mesh upper, these shoes provide excellent ventilation during intense runs. The cushioned midsole offers responsive and energy-returning support, reducing fatigue and enhancing your stride.", "Fabric shoes perfect for jogging and walking", 250.00m, "Image1.jpg", "Running Shoes", "Adidas" },
                    { "C167452B", "This woolen winter hat is the perfect accessory to keep you cozy and stylish during cold weather. Made from high-quality, soft wool, this hat offers excellent insulation and warmth. Its thick and plush construction provides superior protection against chilly winds and frosty temperatures. The hat features a snug fit and a foldable cuff, allowing you to adjust the coverage according to your preference.", "75% Pure Wool Hat for winter weather", 125.00m, "Image2.jpg", "Wool Hat", "Ellos" },
                    { "F129753R", "The 'SilkGlow' silken scarf is a luxurious accessory that adds elegance and sophistication to any outfit. Made from premium-quality silk, this scarf offers a smooth and soft touch against the skin. Its lightweight and flowing fabric drapes beautifully, creating a graceful and graceful look. The 'SilkGlow' scarf features a vibrant and lustrous sheen that catches the light, adding a touch of glamour to your ensemble.", "Silken scarf for summer evenings", 300.00m, "Image3.jpg", "Silk Scarf", "Zara" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ArticleId", "TagId" },
                values: new object[,]
                {
                    { "A12395B", 1 },
                    { "A12395B", 3 },
                    { "C167452B", 2 },
                    { "C167452B", 3 },
                    { "F129753R", 1 },
                    { "F129753R", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "A12395B", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "A12395B", 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "C167452B", 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "C167452B", 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "F129753R", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { "F129753R", 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleId",
                keyValue: "A12395B");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleId",
                keyValue: "C167452B");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleId",
                keyValue: "F129753R");
        }
    }
}
