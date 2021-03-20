using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class PaymentTerms
    {
        public int Id { get; set; }
        public string PaymentTerm { get; set; }
        public int PaymentTermDays { get; set; }
        public int PaymentDuplicates { get; set; }

        public PaymentTerms()
        {
        }

        public PaymentTerms(int id, string paymentTerm, int paymentTermDays, int paymentDuplicates)
        {
            Id = id;
            PaymentTerm = paymentTerm;
            PaymentTermDays = paymentTermDays;
            PaymentDuplicates = paymentDuplicates;
        }
    }
}
