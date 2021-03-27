using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddressName = table.Column<string>(nullable: true),
                    AddessNumber = table.Column<string>(nullable: true),
                    AddressComplement = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreightTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FreightType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreightTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentForm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PoReference = table.Column<string>(nullable: true),
                    POrderDate = table.Column<DateTime>(nullable: false),
                    PSendingDate = table.Column<DateTime>(nullable: false),
                    PoFiscalCupom = table.Column<int>(nullable: false),
                    PoTrackingId = table.Column<string>(nullable: true),
                    PoObservation = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PurchaseOrderTotalValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ncm = table.Column<int>(nullable: false),
                    Ipi = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reseller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResellerName = table.Column<string>(nullable: true),
                    ResellerFantasyName = table.Column<string>(nullable: true),
                    ResellerCnpj = table.Column<int>(nullable: false),
                    StateInscription = table.Column<int>(nullable: false),
                    StateInscriptionExemption = table.Column<bool>(nullable: false),
                    MunicipalInscription = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    TxComissionRetention = table.Column<double>(nullable: false),
                    Observation = table.Column<long>(nullable: false),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reseller_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierFantasyName = table.Column<string>(nullable: true),
                    SupplierCnpj = table.Column<int>(nullable: false),
                    StateInscription = table.Column<int>(nullable: false),
                    StateInscriptionExemption = table.Column<bool>(nullable: false),
                    MunicipalInscription = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    TxComissionRetention = table.Column<double>(nullable: false),
                    Observation = table.Column<long>(nullable: false),
                    PriceValidityDays = table.Column<int>(nullable: false),
                    AditionalTaxes = table.Column<double>(nullable: false),
                    IcmsTx = table.Column<double>(nullable: false),
                    LocalStockReseller = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    AccountManager = table.Column<string>(nullable: true),
                    AccountManagerPhone = table.Column<int>(nullable: false),
                    AccountManagerEmail = table.Column<string>(nullable: true),
                    SiteLogin = table.Column<string>(nullable: true),
                    SitePassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplier_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PoItemUnitValue = table.Column<double>(nullable: false),
                    PoItemQtde = table.Column<int>(nullable: false),
                    PurchaseOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderItem_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Tweeter = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    TxCommission = table.Column<double>(nullable: false),
                    BaseSalary = table.Column<double>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true),
                    ResellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seller_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seller_Reseller_ResellerId",
                        column: x => x.ResellerId,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartNumber = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    TaxNumberId = table.Column<int>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    WarrantyDays = table.Column<int>(nullable: false),
                    EAN = table.Column<string>(nullable: true),
                    DiferentIcms = table.Column<bool>(nullable: false),
                    DifIcmsTx = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_TaxNumber_TaxNumberId",
                        column: x => x.TaxNumberId,
                        principalTable: "TaxNumber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientName = table.Column<string>(nullable: true),
                    ClientFantasyName = table.Column<string>(nullable: true),
                    ClientCnpj = table.Column<int>(nullable: false),
                    StateInscription = table.Column<int>(nullable: false),
                    StateInscriptionExemption = table.Column<bool>(nullable: false),
                    MunicipalInscription = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Observation = table.Column<long>(nullable: false),
                    OrderObservation = table.Column<long>(nullable: false),
                    ActiveClient = table.Column<bool>(nullable: false),
                    AccountSellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Seller_AccountSellerId",
                        column: x => x.AccountSellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BruteSales = table.Column<double>(nullable: false),
                    LiquidSales = table.Column<double>(nullable: false),
                    SalesCommission = table.Column<double>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    SellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SellerId = table.Column<int>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    SendingDate = table.Column<DateTime>(nullable: false),
                    FiscalCupom = table.Column<int>(nullable: false),
                    TrackingId = table.Column<string>(nullable: true),
                    FreightTypeId = table.Column<int>(nullable: false),
                    FreightValue = table.Column<double>(nullable: false),
                    Observation = table.Column<long>(nullable: false),
                    ResellerFiscalCupom = table.Column<int>(nullable: false),
                    ResellerFiscalCupomDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SalesOrderTotalValue = table.Column<double>(nullable: false),
                    SalesOrderComission = table.Column<double>(nullable: false),
                    ResellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Reseller_ResellerId",
                        column: x => x.ResellerId,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesProposal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SellerId = table.Column<int>(nullable: true),
                    ProposalDate = table.Column<DateTime>(nullable: false),
                    ProposalValidity = table.Column<DateTime>(nullable: false),
                    FreightValue = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Observations = table.Column<long>(nullable: false),
                    ProposalValue = table.Column<double>(nullable: false),
                    ProposalComissionValue = table.Column<double>(nullable: false),
                    ResellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesProposal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesProposal_Reseller_ResellerId",
                        column: x => x.ResellerId,
                        principalTable: "Reseller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesProposal_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    UnitFreightCost = table.Column<double>(nullable: false),
                    CostValidity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stock_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Extension = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<int>(nullable: false),
                    Skype = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Tweeter = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SellerId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    RealizationDate = table.Column<DateTime>(nullable: false),
                    Content = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diary_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diary_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scheduling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SellerId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    ScheduleDate = table.Column<DateTime>(nullable: false),
                    Objetive = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scheduling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scheduling_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scheduling_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComissionDuplicate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ComissionDuplicateValue = table.Column<double>(nullable: false),
                    AvaliableDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SalesOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionDuplicate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComissionDuplicate_SalesOrder_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDuplicate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DuplicateValue = table.Column<double>(nullable: false),
                    PayDate = table.Column<DateTime>(nullable: false),
                    SalesOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDuplicate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDuplicate_SalesOrder_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SoItemUnitValue = table.Column<double>(nullable: false),
                    SoItemUnitCost = table.Column<double>(nullable: false),
                    SoItemQtde = table.Column<int>(nullable: false),
                    SalesOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderItem_SalesOrder_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProposalItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProposalItemUnitValue = table.Column<double>(nullable: false),
                    ProposalItemUnitCost = table.Column<double>(nullable: false),
                    ProposalItemQtd = table.Column<int>(nullable: false),
                    SalesProposalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProposalItem_SalesProposal_SalesProposalId",
                        column: x => x.SalesProposalId,
                        principalTable: "SalesProposal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_AccountSellerId",
                table: "Client",
                column: "AccountSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ComissionDuplicate_SalesOrderId",
                table: "ComissionDuplicate",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientId",
                table: "Contact",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Diary_ClientId",
                table: "Diary",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Diary_SellerId",
                table: "Diary",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_SellerId",
                table: "Goals",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDuplicate_SalesOrderId",
                table: "PaymentDuplicate",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierId",
                table: "Product",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TaxNumberId",
                table: "Product",
                column: "TaxNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalItem_SalesProposalId",
                table: "ProposalItem",
                column: "SalesProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItem_PurchaseOrderId",
                table: "PurchaseOrderItem",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reseller_AddressId",
                table: "Reseller",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_ResellerId",
                table: "SalesOrder",
                column: "ResellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder_SellerId",
                table: "SalesOrder",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItem_SalesOrderId",
                table: "SalesOrderItem",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesProposal_ResellerId",
                table: "SalesProposal",
                column: "ResellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesProposal_SellerId",
                table: "SalesProposal",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Scheduling_ClientId",
                table: "Scheduling",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Scheduling_SellerId",
                table: "Scheduling",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_ResellerId",
                table: "Seller",
                column: "ResellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductId",
                table: "Stock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_SupplierId",
                table: "Stock",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_AddressId",
                table: "Supplier",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComissionDuplicate");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropTable(
                name: "FreightTypes");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "PaymentDuplicate");

            migrationBuilder.DropTable(
                name: "PaymentForms");

            migrationBuilder.DropTable(
                name: "ProposalItem");

            migrationBuilder.DropTable(
                name: "PurchaseOrderItem");

            migrationBuilder.DropTable(
                name: "SalesOrderItem");

            migrationBuilder.DropTable(
                name: "Scheduling");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "SalesProposal");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "SalesOrder");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "TaxNumber");

            migrationBuilder.DropTable(
                name: "Reseller");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
