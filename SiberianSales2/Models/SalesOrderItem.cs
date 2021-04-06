using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class SalesOrderItem
    {
        public int Id { get; set; }
        public double SoItemUnitValue { get; set; }
        public double SoItemUnitCost { get; set; }
        public int SoItemQtde { get; set; }
        public int SalesOrderId { get; set; }

        public double TotalValueProduct ()
        {
            return SoItemUnitValue * SoItemQtde;
        }

        public double TotalCostProduct()
        {
            return SoItemUnitCost * SoItemQtde;
        }

        public double TotalComissionProduct()
        {
            return TotalValueProduct() - TotalCostProduct();
        }

        public SalesOrderItem()
        {
        }

        public SalesOrderItem(int id, double soItemUnitValue, int soItemQtde, int salesOrderId)
        {
            Id = id;
            SoItemUnitValue = soItemUnitValue;
            SoItemQtde = soItemQtde;
            SalesOrderId = salesOrderId;
        }

        //Falta criar o método de decrescimo do estoque
    }
}
