using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Data;
using SiberianSales2.Models;

namespace SiberianSales2.Services
{
    public class AddressService
    {
        private readonly SiberianSales2Context _context;

        public AddressService(SiberianSales2Context context)
        {
            _context = context;
        }

        public List<Address> FindAll()
        {
            return _context.Address.OrderBy(x => x.AddressName).ToList();
        }
    }
}
