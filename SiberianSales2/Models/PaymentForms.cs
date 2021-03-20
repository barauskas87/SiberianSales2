using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class PaymentForms
    {
        public int Id { get; set; }
        public string PaymentForm { get; set; }

        public PaymentForms()
        {
        }

        public PaymentForms(int id, string paymentForm)
        {
            Id = id;
            PaymentForm = paymentForm;
        }
    }
}
