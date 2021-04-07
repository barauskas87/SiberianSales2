using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Goals
    {
        public int Id { get; set; }
        public double BruteSales { get; set; }
        public double LiquidSales { get; set; }
        public double SalesCommission { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int SellerId { get; set; }

        public Goals()
        {
        }

        public Goals(int id, double bruteSales, double liquidSales, double salesCommission, string month, int year, int sellerId)
        {
            Id = id;
            BruteSales = bruteSales;
            LiquidSales = liquidSales;
            SalesCommission = salesCommission;
            Month = month;
            Year = year;
            SellerId = sellerId;
        }
    }
}
