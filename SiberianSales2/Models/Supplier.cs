using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierFantasyName { get; set; }
        public int SupplierCnpj { get; set; }
        public int StateInscription { get; set; }
        public bool StateInscriptionExemption { get; set; }
        public int MunicipalInscription { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public double TxComissionRetention { get; set; }
        public long Observation { get; set; }
        public int PriceValidityDays { get; set; }
        public double AditionalTaxes { get; set; }
        public double IcmsTx { get; set; }
        public bool LocalStockReseller { get; set; }
        public Address Address { get; set; }
        public string AccountManager { get; set; }
        public int AccountManagerPhone { get; set; }
        public string AccountManagerEmail { get; set; }
        public string SiteLogin { get; set; }
        public string SitePassword { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product pn)
        {
            Products.Add(pn);
        }

        public Supplier()
        {
        }

        public Supplier(int id, string supplierName, string supplierFantasyName, int supplierCnpj, int stateInscription, bool stateInscriptionExemption, int municipalInscription, string phone, string website, double txComissionRetention, long observation, int priceValidityDays, double aditionalTaxes, double icmsTx, bool localStockReseller, Address address, string accountManager, int accountManagerPhone, string accountManagerEmail, string siteLogin, string sitePassword)
        {
            Id = id;
            SupplierName = supplierName;
            SupplierFantasyName = supplierFantasyName;
            SupplierCnpj = supplierCnpj;
            StateInscription = stateInscription;
            StateInscriptionExemption = stateInscriptionExemption;
            MunicipalInscription = municipalInscription;
            Phone = phone;
            Website = website;
            TxComissionRetention = txComissionRetention;
            Observation = observation;
            PriceValidityDays = priceValidityDays;
            AditionalTaxes = aditionalTaxes;
            IcmsTx = icmsTx;
            LocalStockReseller = localStockReseller;
            Address = address;
            AccountManager = accountManager;
            AccountManagerPhone = accountManagerPhone;
            AccountManagerEmail = accountManagerEmail;
            SiteLogin = siteLogin;
            SitePassword = sitePassword;
        }
    }
}
