using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hemsida_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class removedcountryfromaddressentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
