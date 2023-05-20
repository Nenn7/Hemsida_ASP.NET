using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemsida_ASP.NET.Migrations.Data
{
    /// <inheritdoc />
    public partial class addedvendorname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VendorName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorName",
                table: "Products");
        }
    }
}
