using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class OthersCorrection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "PurchaseOrderItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItem_ProductId",
                table: "PurchaseOrderItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItem_Product_ProductId",
                table: "PurchaseOrderItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItem_Product_ProductId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItem_ProductId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PurchaseOrderItem");
        }
    }
}
