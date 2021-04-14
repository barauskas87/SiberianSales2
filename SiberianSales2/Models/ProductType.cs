using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ProductType()
        {
        }

        public ProductType(int id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }
    }
}
