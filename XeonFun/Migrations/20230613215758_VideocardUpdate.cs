using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XeonFun.Migrations
{
    /// <inheritdoc />
    public partial class VideocardUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orders",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orders",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");
        }
    }
}
