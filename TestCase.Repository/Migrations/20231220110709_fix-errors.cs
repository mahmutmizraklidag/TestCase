using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCase.Repository.Migrations
{
    /// <inheritdoc />
    public partial class fixerrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consumption",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "Consumption",
                table: "ProductUses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consumption",
                table: "ProductUses");

            migrationBuilder.AddColumn<double>(
                name: "Consumption",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
