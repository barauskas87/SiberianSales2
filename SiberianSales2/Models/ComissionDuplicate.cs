using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models.Enums;

namespace SiberianSales2.Models
{
    public class ComissionDuplicate
    {
                
        public int Id { get; set; }
        public double ComissionDuplicateValue { get; set; }
        public DateTime AvaliableDate { get; set; }
        public ComissionStatus Status { get; set; }

        public ComissionDuplicate()
        {
        }

        public ComissionDuplicate(int id, double comissionDuplicateValue, DateTime avaliableDate, ComissionStatus status)
        {
            Id = id;
            ComissionDuplicateValue = comissionDuplicateValue;
            AvaliableDate = avaliableDate;
            Status = status;
        }



        //Criar método para calcular as parcelas
        //Criar método para calcular a data de vencimento das parcelas
    }
}
