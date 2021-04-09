using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class MoreCorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Client_ClientId",
                table: "Scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Seller_SellerId",
                table: "Scheduling");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Scheduling",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Scheduling",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_AddressId",
                table: "Supplier",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_SupplierId",
                table: "Stock",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Reseller_AddressId",
                table: "Reseller",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reseller_Address_AddressId",
                table: "Reseller",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Client_ClientId",
                table: "Scheduling",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Seller_SellerId",
                table: "Scheduling",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Supplier_SupplierId",
                table: "Stock",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Address_AddressId",
                table: "Supplier",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Reseller_Address_AddressId",
                table: "Reseller");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Client_ClientId",
                table: "Scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Seller_SellerId",
                table: "Scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Supplier_SupplierId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Address_AddressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_AddressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Stock_SupplierId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Reseller_AddressId",
                table: "Reseller");

            migrationBuilder.DropIndex(
                name: "IX_Client_AddressId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Scheduling",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Scheduling",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Client_ClientId",
                table: "Scheduling",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Seller_SellerId",
                table: "Scheduling",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
