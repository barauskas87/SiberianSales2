using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public double PoItemUnitValue { get; set; }
        public int PoItemQtde { get; set; }
        public int PurchaseOrderId { get; set; }

        public double TotalValueItem ()
        {
            return PoItemQtde * PoItemUnitValue;
        }

        public PurchaseOrderItem()
        {
        }

        public PurchaseOrderItem(int id, double poItemUnitValue, int poItemQtde, int purchaseOrderId)
        {
            Id = id;
            PoItemUnitValue = poItemUnitValue;
            PoItemQtde = poItemQtde;
            PurchaseOrderId = purchaseOrderId;
        }


        //Falta criar o método de acrescimo do estoque
    }
}
