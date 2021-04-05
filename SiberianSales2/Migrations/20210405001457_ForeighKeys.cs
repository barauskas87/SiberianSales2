using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class ForeighKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Seller_AccountSellerId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionDuplicate_SalesOrder_SalesOrderId",
                table: "ComissionDuplicate");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Diary_Client_ClientId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_Diary_Seller_SellerId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Seller_SellerId",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDuplicate_SalesOrder_SalesOrderId",
                table: "PaymentDuplicate");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductType_ProductTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProposalItem_SalesProposal_SalesProposalId",
                table: "ProposalItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrder_PurchaseOrderId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Reseller_Address_AddressId",
                table: "Reseller");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Seller_SellerId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesProposal_Seller_SellerId",
                table: "SalesProposal");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Reseller_ResellerId",
                table: "Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock");

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
                name: "IX_Client_AccountSellerId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_AddressId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Stock",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Stock",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResellerId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesProposal",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observations",
                table: "SalesProposal",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "SalesOrderItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesOrder",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Reseller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PurchaseOrderItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PoObservation",
                table: "PurchaseOrder",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "SalesProposalId",
                table: "ProposalItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "PaymentDuplicate",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Goals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Diary",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Diary",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Diary",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "ComissionDuplicate",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountSellerId",
                table: "Client",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Client",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_SellerId",
                table: "Client",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionDuplicate_SalesOrder_SalesOrderId",
                table: "ComissionDuplicate",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_Client_ClientId",
                table: "Diary",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_Seller_SellerId",
                table: "Diary",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Seller_SellerId",
                table: "Goals",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDuplicate_SalesOrder_SalesOrderId",
                table: "PaymentDuplicate",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductType_ProductTypeId",
                table: "Product",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalItem_SalesProposal_SalesProposalId",
                table: "ProposalItem",
                column: "SalesProposalId",
                principalTable: "SalesProposal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrder_PurchaseOrderId",
                table: "PurchaseOrderItem",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Seller_SellerId",
                table: "SalesOrder",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesProposal_Seller_SellerId",
                table: "SalesProposal",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Reseller_ResellerId",
                table: "Seller",
                column: "ResellerId",
                principalTable: "Reseller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Seller_SellerId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionDuplicate_SalesOrder_SalesOrderId",
                table: "ComissionDuplicate");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Diary_Client_ClientId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_Diary_Seller_SellerId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Seller_SellerId",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDuplicate_SalesOrder_SalesOrderId",
                table: "PaymentDuplicate");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductType_ProductTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProposalItem_SalesProposal_SalesProposalId",
                table: "ProposalItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrder_PurchaseOrderId",
                table: "PurchaseOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrder_Seller_SellerId",
                table: "SalesOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesProposal_Seller_SellerId",
                table: "SalesProposal");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Reseller_ResellerId",
                table: "Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Client_SellerId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Stock",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Stock",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ResellerId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesProposal",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Observations",
                table: "SalesProposal",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "SalesOrderItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "SalesOrder",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Reseller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PurchaseOrderItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "PoObservation",
                table: "PurchaseOrder",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalesProposalId",
                table: "ProposalItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "PaymentDuplicate",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Goals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Diary",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Content",
                table: "Diary",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Diary",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "ComissionDuplicate",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Client",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AccountSellerId",
                table: "Client",
                nullable: true,
                oldClrType: typeof(int));

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
                name: "IX_Client_AccountSellerId",
                table: "Client",
                column: "AccountSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Seller_AccountSellerId",
                table: "Client",
                column: "AccountSellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionDuplicate_SalesOrder_SalesOrderId",
                table: "ComissionDuplicate",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_Client_ClientId",
                table: "Diary",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_Seller_SellerId",
                table: "Diary",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Seller_SellerId",
                table: "Goals",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDuplicate_SalesOrder_SalesOrderId",
                table: "PaymentDuplicate",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductType_ProductTypeId",
                table: "Product",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProposalItem_SalesProposal_SalesProposalId",
                table: "ProposalItem",
                column: "SalesProposalId",
                principalTable: "SalesProposal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItem_PurchaseOrder_PurchaseOrderId",
                table: "PurchaseOrderItem",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reseller_Address_AddressId",
                table: "Reseller",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrder_Seller_SellerId",
                table: "SalesOrder",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesProposal_Seller_SellerId",
                table: "SalesProposal",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Reseller_ResellerId",
                table: "Seller",
                column: "ResellerId",
                principalTable: "Reseller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Product_ProductId",
                table: "Stock",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Supplier_SupplierId",
                table: "Stock",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Address_AddressId",
                table: "Supplier",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
