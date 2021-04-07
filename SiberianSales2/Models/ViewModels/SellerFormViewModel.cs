using System.Collections.Generic;

namespace SiberianSales2.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Reseller> Resellers { get; set; }
    }
}
