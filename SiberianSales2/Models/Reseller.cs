using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Reseller
    {
        public int Id { get; set; }
        public string ResellerName { get; set; }
        public string ResellerFantasyName { get; set; }
        public string ResellerCnpj { get; set; }
        public string StateInscription { get; set; }
        public bool StateInscriptionExemption { get; set; }
        public string MunicipalInscription { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public double TxComissionRetention { get; set; }
        public string Observation { get; set; }
        public Address Address { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public ICollection<SalesProposal> ResellerSalesProposals { get; set; } = new List<SalesProposal>();
        public ICollection<SalesOrder> ResellerSalesOrders { get; set; } = new List<SalesOrder>();

        public Reseller()
        {
        }

        public Reseller(int id, string resellerName, string resellerFantasyName, string resellerCnpj, string stateInscription, bool stateInscriptionExemption, string municipalInscription, string phone, string website, double txComissionRetention, string observation, Address address)
        {
            Id = id;
            ResellerName = resellerName;
            ResellerFantasyName = resellerFantasyName;
            ResellerCnpj = resellerCnpj;
            StateInscription = stateInscription;
            StateInscriptionExemption = stateInscriptionExemption;
            MunicipalInscription = municipalInscription;
            Phone = phone;
            Website = website;
            TxComissionRetention = txComissionRetention;
            Observation = observation;
            Address = address;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public void RemoveSeller(Seller seller)
        {
            Sellers.Remove(seller);
        }

        public double TotalResellerSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

        public double TotalResellerComission(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalComission(initial, final));
        }

        public double TotalResellerProposal(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalProposal(initial, final));
        }

        public double TotalResellerProposalComission(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalProposalComission(initial, final));
        }
    }
}
