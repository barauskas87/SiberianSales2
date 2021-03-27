using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class FreightTypes
    {
        public int Id { get; set; }
        public string FreightType { get; set; }

        public FreightTypes()
        {
        }

        public FreightTypes(int id, string freightType)
        {
            Id = id;
            FreightType = freightType;
        }
    }
}
