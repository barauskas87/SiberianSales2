using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double PoItemUnitValue { get; set; }
        public int PoItemQtde { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public int PurchaseOrderId { get; set; }

        public double TotalValueItem ()
        {
            return PoItemQtde * PoItemUnitValue;
        }

        public PurchaseOrderItem()
        {
        }

        public PurchaseOrderItem(int id, int productId, double poItemUnitValue, int poItemQtde, int purchaseOrderId)
        {
            Id = id;
            ProductId = productId;
            PoItemUnitValue = poItemUnitValue;
            PoItemQtde = poItemQtde;
            PurchaseOrderId = purchaseOrderId;
        }




        //Falta criar o método de acrescimo do estoque
    }
}
