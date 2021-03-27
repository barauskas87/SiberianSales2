using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models;
using SiberianSales2.Models.Enums;

namespace SiberianSales2.Data
{
    public class SeedingService
    {
        private SiberianSales2Context _context;

        public SeedingService(SiberianSales2Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesOrder.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Hardware");
            Department d2 = new Department(2, "Software");
            Department d3 = new Department(3, "Services");

            Seller s1 = new Seller { Id = 1, Name = "Cristiane Gomes de Lima Barauskas", Email = "cristiane@siberiantech.com.br", BirthDate = new DateTime(1982,2,6), Department = d1, Phone = "11988972760", BaseSalary = 4000.00};
            Seller s2 = new Seller { Id = 2, Name = "Victor Barauskas Bezerra da Silva", Email = "victor@siberiantech.com.br", BirthDate = new DateTime(1987,11,21), Department = d2, Phone = "11988879345", BaseSalary = 4000.00};

            _context.Department.AddRange(d1, d2, d3);
            _context.Seller.AddRange(s1, s2);

            _context.SaveChanges();
        }
    }
}
