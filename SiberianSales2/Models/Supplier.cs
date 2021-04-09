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
        public string SupplierCnpj { get; set; }
        public string StateInscription { get; set; }
        public bool StateInscriptionExemption { get; set; }
        public string MunicipalInscription { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public double TxComissionRetention { get; set; }
        public string Observation { get; set; }
        public int PriceValidityDays { get; set; }
        public double AditionalTaxes { get; set; }
        public double IcmsTx { get; set; }
        public bool LocalStockReseller { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public string AccountManager { get; set; }
        public string AccountManagerPhone { get; set; }
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

        public Supplier(int id, string supplierName, string supplierFantasyName, string supplierCnpj, string stateInscription, bool stateInscriptionExemption, string municipalInscription, string phone, string website, double txComissionRetention, string observation, int priceValidityDays, double aditionalTaxes, double icmsTx, bool localStockReseller, int addressId, string accountManager, string accountManagerPhone, string accountManagerEmail, string siteLogin, string sitePassword)
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
            AddressId = addressId;
            AccountManager = accountManager;
            AccountManagerPhone = accountManagerPhone;
            AccountManagerEmail = accountManagerEmail;
            SiteLogin = siteLogin;
            SitePassword = sitePassword;
        }
    }
}
