using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class ProposalItem
    {
        public int Id { get; set; }
        public double ProposalItemUnitValue { get; set; }
        public double ProposalItemUnitCost { get; set; }
        public int ProposalItemQtd { get; set; }
        public SalesProposal SalesProposal { get; set; }
        public int SalesProposalId { get; set; }

        public double ProposalItemTotalValue()
        {
            return ProposalItemUnitValue * ProposalItemQtd;
        }

        public double ProposalItemTotalCost()
        {
            return ProposalItemUnitCost * ProposalItemQtd;
        }

        public double TotalComissionProduct()
        {
            return ProposalItemTotalValue() - ProposalItemTotalCost();
        }

        public ProposalItem()
        {
        }

        public ProposalItem(int id, double proposalItemUnitValue, int proposalItemQtd, int salesProposalId)
        {
            Id = id;
            ProposalItemUnitValue = proposalItemUnitValue;
            ProposalItemQtd = proposalItemQtd;
            SalesProposalId = salesProposalId;
        }
    }
}
