using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class OthersCorrection4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_TaxNumber_TaxNumberId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "TaxNumberId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_TaxNumber_TaxNumberId",
                table: "Product",
                column: "TaxNumberId",
                principalTable: "TaxNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_TaxNumber_TaxNumberId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "TaxNumberId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_TaxNumber_TaxNumberId",
                table: "Product",
                column: "TaxNumberId",
                principalTable: "TaxNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
