using System.Collections.Generic;
using System;
using System.Linq;

namespace SiberianSales2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller (Seller seller)
        {
            Sellers.Add(seller);
        }

        public void RemoveSeller(Seller seller)
        {
            Sellers.Remove(seller);
        }

        public double TotalDepartmentSales (DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

        public double TotalDepartmentComission(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalComission(initial, final));
        }

        public double TotalDepartmentProposal(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalProposal(initial, final));
        }

        public double TotalDepartmentProposalComission(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalProposalComission(initial, final));
        }
    }
}
