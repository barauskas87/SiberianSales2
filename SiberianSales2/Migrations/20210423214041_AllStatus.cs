using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class AllStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SalesProposal",
                newName: "ProposalStatusId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SalesOrder",
                newName: "SalesOrderStatusId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PurchaseOrder",
                newName: "PurchaseOrderStatusId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ComissionDuplicate",
                newName: "ComissionStatusId");

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ComissionStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProposalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesProposal_ProposalStatusId",
                table: "SalesProposal",
                column: "ProposalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_SalesOrderStatusId",
                table: "SalesOrder",
                column: "SalesOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PurchaseOrderStatusId",
                table: "PurchaseOrder",
                column: "PurchaseOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ComissionDuplicate_ComissionStatusId",
                table: "ComissionDuplicate",
                column: "ComissionStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionDuplicate_ComissionStatus_ComissionStatusId",
                table: "ComissionDuplicate",
                column: "ComissionStatusId",
                principalTable: "ComissionStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_PurchaseOrderStatus_PurchaseOrderStatusId",
                table: "PurchaseOrder",
                column: "PurchaseOrderStatusId",
                principalTable: "PurchaseOrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_SalesOrderStatus_SalesOrderStatusId",
                table: "SalesOrder",
                column: "SalesOrderStatusId",
                principalTable: "SalesOrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesProposal_ProposalStatus_ProposalStatusId",
                table: "SalesProposal",
                column: "ProposalStatusId",
                principalTable: "ProposalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComissionDuplicate_ComissionStatus_ComissionStatusId",
                table: "ComissionDuplicate");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_PurchaseOrderStatus_PurchaseOrderStatusId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_SalesOrderStatus_SalesOrderStatusId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesProposal_ProposalStatus_ProposalStatusId",
                table: "SalesProposal");

            migrationBuilder.DropTable(
                name: "ComissionStatus");

            migrationBuilder.DropTable(
                name: "ProposalStatus");

            migrationBuilder.DropTable(
                name: "PurchaseOrderStatus");

            migrationBuilder.DropTable(
                name: "SalesOrderStatus");

            migrationBuilder.DropIndex(
                name: "IX_SalesProposal_ProposalStatusId",
                table: "SalesProposal");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrder_SalesOrderStatusId",
                table: "SalesOrder");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_PurchaseOrderStatusId",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_ComissionDuplicate_ComissionStatusId",
                table: "ComissionDuplicate");

            migrationBuilder.RenameColumn(
                name: "ProposalStatusId",
                table: "SalesProposal",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "SalesOrderStatusId",
                table: "SalesOrder",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderStatusId",
                table: "PurchaseOrder",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ComissionStatusId",
                table: "ComissionDuplicate",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
