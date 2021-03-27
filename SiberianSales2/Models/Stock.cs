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
        public Supplier Supplier { get; set; }
        public double Cost { get; set; }
        public double UnitFreightCost { get; set; }
        public int CostValidity { get; set; }

        public Stock()
        {
        }

        public Stock(int id, Product product, Supplier supplier, double cost, double unitFreightCost, int costValidity)
        {
            Id = id;
            Product = product;
            Supplier = supplier;
            Cost = cost;
            UnitFreightCost = unitFreightCost;
            CostValidity = costValidity;
        }
    }
}
