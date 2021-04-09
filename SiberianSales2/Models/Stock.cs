using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public double Cost { get; set; }
        public double UnitFreightCost { get; set; }
        public int CostValidity { get; set; }

        public Stock()
        {
        }

        public Stock(int id, int productId, int supplierId, double cost, double unitFreightCost, int costValidity)
        {
            Id = id;
            ProductId = productId;
            SupplierId = supplierId;
            Cost = cost;
            UnitFreightCost = unitFreightCost;
            CostValidity = costValidity;
        }
    }
}
