using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class ClientCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AccountSellerId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Client",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AccountSellerId",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
