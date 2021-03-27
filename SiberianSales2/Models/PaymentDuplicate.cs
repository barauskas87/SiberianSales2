using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class PaymentDuplicate
    {
        public int Id { get; set; }
        public double DuplicateValue { get; set; }
        public DateTime PayDate { get; set; }

        public PaymentDuplicate()
        {
        }

        public PaymentDuplicate(int id, double duplicateValue, DateTime payDate)
        {
            Id = id;
            DuplicateValue = duplicateValue;
            PayDate = payDate;
        }



        //Criar método para calcular as parcelas
        //Criar método para calcular a data de vencimento das parcelas
    }
}
