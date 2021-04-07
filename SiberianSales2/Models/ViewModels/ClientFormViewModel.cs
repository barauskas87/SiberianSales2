using System.Collections.Generic;

namespace SiberianSales2.Models.ViewModels
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
