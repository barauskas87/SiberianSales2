using System.Collections.Generic;

namespace SiberianSales2.Models.ViewModels
{
    public class SupplierFormViewModel
    {
        public Supplier Supplier { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
