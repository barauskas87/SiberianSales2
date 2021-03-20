using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class TaxNumber
    {
        public int Id { get; set; }
        public int Ncm { get; set; }
        public double Ipi { get; set; }

        public TaxNumber()
        {
        }

        public TaxNumber(int id, int ncm, double ipi)
        {
            Id = id;
            Ncm = ncm;
            Ipi = ipi;
        }
    }
}
