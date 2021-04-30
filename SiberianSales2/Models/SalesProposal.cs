using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class SalesProposal
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime ProposalDate { get; set; }
        public DateTime ProposalValidity { get; set; }
        public double FreightValue { get; set; }
        public ProposalStatus ProposalStatus { get; set; }
        public int ProposalStatusId { get; set; }
        public string Observations { get; set; }
        public double ProposalValue { get; set; }
        public double ProposalComissionValue { get; set; }
        public ICollection<ProposalItem> ProposalItems { get; set; } = new List<ProposalItem>();


        public void AddProposalItem(ProposalItem spi)
        {
            ProposalItems.Add(spi);
        }

        public void RemoveProposalItem(ProposalItem spi)
        {
            ProposalItems.Remove(spi);
        }

        public void TotalProposalValue()
        {
            foreach (ProposalItem obj in ProposalItems)
            {
                ProposalValue = +obj.ProposalItemTotalValue();
            }
        }

        public void TotalProposalComission()
        {
            foreach (ProposalItem obj in ProposalItems)
            {
                ProposalComissionValue = +obj.TotalComissionProduct();
            }
        }

        public SalesProposal()
        {
        }

        public SalesProposal(int id, string reference, int sellerId, int clientId, DateTime proposalDate, DateTime proposalValidity, double freightValue, int proposalStatusId, string observations, double proposalValue, double proposalComissionValue, ICollection<ProposalItem> proposalItems)
        {
            Id = id;
            Reference = reference;
            SellerId = sellerId;
            ClientId = clientId;
            ProposalDate = proposalDate;
            ProposalValidity = proposalValidity;
            FreightValue = freightValue;
            ProposalStatusId = proposalStatusId;
            Observations = observations;
            ProposalValue = proposalValue;
            ProposalComissionValue = proposalComissionValue;
            ProposalItems = proposalItems;
        }



        //Falta criar o método que cria o pedido de venda a partir da proposta

    }
}
