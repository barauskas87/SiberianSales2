using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Manufacturer { get; set; }
        public TaxNumber TaxNumber { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int WarrantyDays { get; set; }
        public string EAN { get; set; }
        public bool DiferentIcms { get; set; }
        public double DifIcmsTx { get; set; }
        public ICollection<Stock> ProductStock { get; set; } = new List<Stock>();

        public void AddProductStock (Stock ps)
        {
            ProductStock.Add(ps);
        }

        public Product()
        {
        }

        public Product(int id, string partNumber, string productName, string productDescription, string manufacturer, TaxNumber taxNumber, double weight, double height, double length, double width, int warrantyDays, string eAN, bool diferentIcms, double difIcmsTx)
        {
            Id = id;
            PartNumber = partNumber;
            ProductName = productName;
            ProductDescription = productDescription;
            Manufacturer = manufacturer;
            TaxNumber = taxNumber;
            Weight = weight;
            Height = height;
            Length = length;
            Width = width;
            WarrantyDays = warrantyDays;
            EAN = eAN;
            DiferentIcms = diferentIcms;
            DifIcmsTx = difIcmsTx;
        }
    }
}
