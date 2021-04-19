using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Models;

namespace SiberianSales2.Data
{
    public class SiberianSales2Context : DbContext
    {
        public SiberianSales2Context (DbContextOptions<SiberianSales2Context> options)
            : base(options)
        {
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ComissionDuplicate> ComissionDuplicate { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Diary> Diary { get; set; }
        public DbSet<FreightTypes> FreightTypes { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<PaymentDuplicate> PaymentDuplicate { get; set; }
        public DbSet<PaymentForms> PaymentForms { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProposalItem> ProposalItem { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItem { get; set; }
        public DbSet<Reseller> Reseller { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<SalesOrderItem> SalesOrderItem { get; set; }
        public DbSet<SalesProposal> SalesProposal { get; set; }
        public DbSet<Scheduling> Scheduling { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<TaxNumber> TaxNumber { get; set; }
        public DbSet<SiberianSales2.Models.PaymentTerms> PaymentTerms { get; set; }
        public IEnumerable ProposalStatus { get; internal set; }
    }
}
