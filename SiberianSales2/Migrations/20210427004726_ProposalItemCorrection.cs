using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class ProposalItemCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProposalItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProposalItem_ProductId",
                table: "ProposalItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalItem_Product_ProductId",
                table: "ProposalItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProposalItem_Product_ProductId",
                table: "ProposalItem");

            migrationBuilder.DropIndex(
                name: "IX_ProposalItem_ProductId",
                table: "ProposalItem");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProposalItem");
        }
    }
}
