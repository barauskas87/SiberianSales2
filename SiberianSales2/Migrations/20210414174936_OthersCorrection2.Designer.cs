﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiberianSales2.Data;

namespace SiberianSales2.Migrations
{
    [DbContext(typeof(SiberianSales2Context))]
    [Migration("20210414174936_OthersCorrection2")]
    partial class OthersCorrection2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SiberianSales2.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddessNumber");

                    b.Property<string>("AddressComplement");

                    b.Property<string>("AddressName");

                    b.Property<string>("City");

                    b.Property<string>("District");

                    b.Property<int>("PostalCode");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SiberianSales2.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ActiveClient");

                    b.Property<int>("AddressId");

                    b.Property<string>("ClientCnpj");

                    b.Property<string>("ClientFantasyName");

                    b.Property<string>("ClientName");

                    b.Property<string>("MunicipalInscription");

                    b.Property<string>("Observation");

                    b.Property<string>("OrderObservation");

                    b.Property<string>("Phone");

                    b.Property<int>("SellerId");

                    b.Property<string>("StateInscription");

                    b.Property<bool>("StateInscriptionExemption");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("SellerId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("SiberianSales2.Models.ComissionDuplicate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AvaliableDate");

                    b.Property<double>("ComissionDuplicateValue");

                    b.Property<int>("SalesOrderId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("ComissionDuplicate");
                });

            modelBuilder.Entity("SiberianSales2.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("ClientId");

                    b.Property<string>("Email");

                    b.Property<int>("Extension");

                    b.Property<string>("Facebook");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Skype");

                    b.Property<string>("Tweeter");

                    b.Property<string>("Whatsapp");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SiberianSales2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SiberianSales2.Models.Diary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("RealizationDate");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("SellerId");

                    b.ToTable("Diary");
                });

            modelBuilder.Entity("SiberianSales2.Models.FreightTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FreightType");

                    b.HasKey("Id");

                    b.ToTable("FreightTypes");
                });

            modelBuilder.Entity("SiberianSales2.Models.Goals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BruteSales");

                    b.Property<double>("LiquidSales");

                    b.Property<string>("Month");

                    b.Property<double>("SalesCommission");

                    b.Property<int>("SellerId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("SiberianSales2.Models.PaymentDuplicate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("DuplicateValue");

                    b.Property<DateTime>("PayDate");

                    b.Property<int>("SalesOrderId");

                    b.HasKey("Id");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("PaymentDuplicate");
                });

            modelBuilder.Entity("SiberianSales2.Models.PaymentForms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PaymentForm");

                    b.HasKey("Id");

                    b.ToTable("PaymentForms");
                });

            modelBuilder.Entity("SiberianSales2.Models.PaymentTerms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PaymentDuplicates");

                    b.Property<string>("PaymentTerm");

                    b.Property<int>("PaymentTermDays");

                    b.HasKey("Id");

                    b.ToTable("PaymentTerms");
                });

            modelBuilder.Entity("SiberianSales2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("DifIcmsTx");

                    b.Property<bool>("DiferentIcms");

                    b.Property<string>("EAN");

                    b.Property<double>("Height");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("PartNumber");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.Property<int>("ProductTypeId");

                    b.Property<int?>("SupplierId");

                    b.Property<int?>("TaxNumberId");

                    b.Property<int>("WarrantyDays");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("TaxNumberId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SiberianSales2.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("SiberianSales2.Models.ProposalItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProposalItemQtd");

                    b.Property<double>("ProposalItemUnitCost");

                    b.Property<double>("ProposalItemUnitValue");

                    b.Property<int>("SalesProposalId");

                    b.HasKey("Id");

                    b.HasIndex("SalesProposalId");

                    b.ToTable("ProposalItem");
                });

            modelBuilder.Entity("SiberianSales2.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("POrderDate");

                    b.Property<DateTime>("PSendingDate");

                    b.Property<int>("PoFiscalCupom");

                    b.Property<string>("PoObservation");

                    b.Property<string>("PoReference");

                    b.Property<string>("PoTrackingId");

                    b.Property<double>("PurchaseOrderTotalValue");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("SiberianSales2.Models.PurchaseOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PoItemQtde");

                    b.Property<double>("PoItemUnitValue");

                    b.Property<int>("ProductId");

                    b.Property<int>("PurchaseOrderId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderItem");
                });

            modelBuilder.Entity("SiberianSales2.Models.Reseller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("MunicipalInscription");

                    b.Property<string>("Observation");

                    b.Property<string>("Phone");

                    b.Property<string>("ResellerCnpj");

                    b.Property<string>("ResellerFantasyName");

                    b.Property<string>("ResellerName");

                    b.Property<string>("StateInscription");

                    b.Property<bool>("StateInscriptionExemption");

                    b.Property<double>("TxComissionRetention");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Reseller");
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FiscalCupom");

                    b.Property<int>("FreightTypeId");

                    b.Property<double>("FreightValue");

                    b.Property<long>("Observation");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("Reference");

                    b.Property<int>("ResellerFiscalCupom");

                    b.Property<DateTime>("ResellerFiscalCupomDate");

                    b.Property<int?>("ResellerId");

                    b.Property<double>("SalesOrderComission");

                    b.Property<double>("SalesOrderTotalValue");

                    b.Property<int>("SellerId");

                    b.Property<DateTime>("SendingDate");

                    b.Property<int>("Status");

                    b.Property<string>("TrackingId");

                    b.HasKey("Id");

                    b.HasIndex("ResellerId");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SalesOrderId");

                    b.Property<int>("SoItemQtde");

                    b.Property<double>("SoItemUnitCost");

                    b.Property<double>("SoItemUnitValue");

                    b.HasKey("Id");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderItem");
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesProposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("FreightValue");

                    b.Property<string>("Observations");

                    b.Property<double>("ProposalComissionValue");

                    b.Property<DateTime>("ProposalDate");

                    b.Property<DateTime>("ProposalValidity");

                    b.Property<double>("ProposalValue");

                    b.Property<int?>("ResellerId");

                    b.Property<int>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ResellerId");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesProposal");
                });

            modelBuilder.Entity("SiberianSales2.Models.Scheduling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Objetive");

                    b.Property<DateTime>("ScheduleDate");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("SellerId");

                    b.ToTable("Scheduling");
                });

            modelBuilder.Entity("SiberianSales2.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Facebook");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Phone2");

                    b.Property<int>("ResellerId");

                    b.Property<string>("Skype");

                    b.Property<string>("Tweeter");

                    b.Property<double>("TxCommission");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ResellerId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SiberianSales2.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<int>("CostValidity");

                    b.Property<int>("ProductId");

                    b.Property<int>("SupplierId");

                    b.Property<double>("UnitFreightCost");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("SiberianSales2.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountManager");

                    b.Property<string>("AccountManagerEmail");

                    b.Property<string>("AccountManagerPhone");

                    b.Property<int>("AddressId");

                    b.Property<double>("AditionalTaxes");

                    b.Property<double>("IcmsTx");

                    b.Property<bool>("LocalStockReseller");

                    b.Property<string>("MunicipalInscription");

                    b.Property<string>("Observation");

                    b.Property<string>("Phone");

                    b.Property<int>("PriceValidityDays");

                    b.Property<string>("SiteLogin");

                    b.Property<string>("SitePassword");

                    b.Property<string>("StateInscription");

                    b.Property<bool>("StateInscriptionExemption");

                    b.Property<string>("SupplierCnpj");

                    b.Property<string>("SupplierFantasyName");

                    b.Property<string>("SupplierName");

                    b.Property<double>("TxComissionRetention");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("SiberianSales2.Models.TaxNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Ipi");

                    b.Property<int>("Ncm");

                    b.HasKey("Id");

                    b.ToTable("TaxNumber");
                });

            modelBuilder.Entity("SiberianSales2.Models.Client", b =>
                {
                    b.HasOne("SiberianSales2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Seller", "Seller")
                        .WithMany("Clients")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.ComissionDuplicate", b =>
                {
                    b.HasOne("SiberianSales2.Models.SalesOrder", "SalesOrder")
                        .WithMany("ComissionDuplicates")
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Contact", b =>
                {
                    b.HasOne("SiberianSales2.Models.Client", "Client")
                        .WithMany("Contacts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Diary", b =>
                {
                    b.HasOne("SiberianSales2.Models.Client", "Client")
                        .WithMany("DiaryTasks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Seller", "Seller")
                        .WithMany("Diaries")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Goals", b =>
                {
                    b.HasOne("SiberianSales2.Models.Seller", "Seller")
                        .WithMany("SellerGoals")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.PaymentDuplicate", b =>
                {
                    b.HasOne("SiberianSales2.Models.SalesOrder", "SalesOrder")
                        .WithMany("PaymentDuplicates")
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Product", b =>
                {
                    b.HasOne("SiberianSales2.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.HasOne("SiberianSales2.Models.TaxNumber", "TaxNumber")
                        .WithMany()
                        .HasForeignKey("TaxNumberId");
                });

            modelBuilder.Entity("SiberianSales2.Models.ProposalItem", b =>
                {
                    b.HasOne("SiberianSales2.Models.SalesProposal", "SalesProposal")
                        .WithMany("ProposalItems")
                        .HasForeignKey("SalesProposalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.PurchaseOrderItem", b =>
                {
                    b.HasOne("SiberianSales2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderItems")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Reseller", b =>
                {
                    b.HasOne("SiberianSales2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesOrder", b =>
                {
                    b.HasOne("SiberianSales2.Models.Reseller")
                        .WithMany("ResellerSalesOrders")
                        .HasForeignKey("ResellerId");

                    b.HasOne("SiberianSales2.Models.Seller")
                        .WithMany("SalesOrders")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesOrderItem", b =>
                {
                    b.HasOne("SiberianSales2.Models.SalesOrder", "SalesOrder")
                        .WithMany("SalesOrdersItems")
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.SalesProposal", b =>
                {
                    b.HasOne("SiberianSales2.Models.Reseller")
                        .WithMany("ResellerSalesProposals")
                        .HasForeignKey("ResellerId");

                    b.HasOne("SiberianSales2.Models.Seller")
                        .WithMany("SalesProposals")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Scheduling", b =>
                {
                    b.HasOne("SiberianSales2.Models.Client", "Client")
                        .WithMany("Schedules")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Seller", "Seller")
                        .WithMany("Schedules")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Seller", b =>
                {
                    b.HasOne("SiberianSales2.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Reseller", "Reseller")
                        .WithMany("Sellers")
                        .HasForeignKey("ResellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Stock", b =>
                {
                    b.HasOne("SiberianSales2.Models.Product", "Product")
                        .WithMany("ProductStock")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiberianSales2.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiberianSales2.Models.Supplier", b =>
                {
                    b.HasOne("SiberianSales2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
