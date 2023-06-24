using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace XeonFun.Migrations
{
    /// <inheritdoc />
    public partial class Videocard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserID",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_Users_UserId",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Address_AddressId1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPhoto_Users_UserId",
                table: "UserPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPhoto",
                table: "UserPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "UserPhoto",
                newName: "UserPhotos");

            migrationBuilder.RenameTable(
                name: "CreditCard",
                newName: "Cards");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_UserPhoto_UserId",
                table: "UserPhotos",
                newName: "IX_UserPhotos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditCard_UserId",
                table: "Cards",
                newName: "IX_Cards_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_UserID",
                table: "Addresses",
                newName: "IX_Addresses_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPhotos",
                table: "UserPhotos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Discount = table.Column<decimal>(type: "numeric", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Warranty = table.Column<int>(type: "integer", nullable: true),
                    ManufactureCode = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    GraphicsProcessor = table.Column<string>(type: "text", nullable: true),
                    Microarchitecture = table.Column<string>(type: "text", nullable: true),
                    TechnicalProcess = table.Column<int>(type: "integer", nullable: true),
                    ChipFrequency = table.Column<int>(type: "integer", nullable: true),
                    ChipTurboBoostFrequency = table.Column<int>(type: "integer", nullable: true),
                    ALU = table.Column<int>(type: "integer", nullable: true),
                    RTX = table.Column<bool>(type: "boolean", nullable: true),
                    RTCores = table.Column<int>(type: "integer", nullable: true),
                    TensorKernels = table.Column<int>(type: "integer", nullable: true),
                    MemoryCapacity = table.Column<int>(type: "integer", nullable: true),
                    MemoryType = table.Column<int>(type: "integer", nullable: true),
                    MaxMemoryBandwidth = table.Column<int>(type: "integer", nullable: true),
                    EffectiveMemoryCapacity = table.Column<int>(type: "integer", nullable: true),
                    MemoryBusBitRate = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserID",
                table: "Addresses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Addresses_AddressId1",
                table: "Order",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhotos_Users_UserId",
                table: "UserPhotos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Addresses_AddressId1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPhotos_Users_UserId",
                table: "UserPhotos");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPhotos",
                table: "UserPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "UserPhotos",
                newName: "UserPhoto");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "CreditCard");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_UserPhotos_UserId",
                table: "UserPhoto",
                newName: "IX_UserPhoto_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_UserId",
                table: "CreditCard",
                newName: "IX_CreditCard_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserID",
                table: "Address",
                newName: "IX_Address_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPhoto",
                table: "UserPhoto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserID",
                table: "Address",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_Users_UserId",
                table: "CreditCard",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Address_AddressId1",
                table: "Order",
                column: "AddressId1",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhoto_Users_UserId",
                table: "UserPhoto",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
