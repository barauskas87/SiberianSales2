using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class ComissionDuplicate
    {
                
        public int Id { get; set; }
        public double ComissionDuplicateValue { get; set; }
        public DateTime AvaliableDate { get; set; }
        public ComissionStatus ComissionStatus { get; set; }
        public int ComissionStatusId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public int SalesOrderId { get; set; }

        public ComissionDuplicate()
        {
        }

        public ComissionDuplicate(int id, double comissionDuplicateValue, DateTime avaliableDate, int comissionStatusId, int salesOrderId)
        {
            Id = id;
            ComissionDuplicateValue = comissionDuplicateValue;
            AvaliableDate = avaliableDate;
            ComissionStatusId = comissionStatusId;
            SalesOrderId = salesOrderId;
        }



        //Criar método para calcular as parcelas
        //Criar método para calcular a data de vencimento das parcelas
    }
}
