using System.Collections.Generic;

namespace SiberianSales2.Models.ViewModels
{
    public class ResellerFormViewModel
    {
        public Reseller Reseller { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
