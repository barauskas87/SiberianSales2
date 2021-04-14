using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class OthersCorrection3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "SalesProposal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "SalesOrder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalesProposal_ClientId",
                table: "SalesProposal",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_ClientId",
                table: "SalesOrder",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Client_ClientId",
                table: "SalesOrder",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesProposal_Client_ClientId",
                table: "SalesProposal",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Client_ClientId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesProposal_Client_ClientId",
                table: "SalesProposal");

            migrationBuilder.DropIndex(
                name: "IX_SalesProposal_ClientId",
                table: "SalesProposal");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrder_ClientId",
                table: "SalesOrder");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SalesProposal");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SalesOrder");
        }
    }
}
