using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Data;
using SiberianSales2.Models;

namespace SiberianSales2.Services
{
    public class ResellerService
    {
        private readonly SiberianSales2Context _context;

        public ResellerService(SiberianSales2Context context)
        {
            _context = context;
        }

        public List<Reseller> FindAll()
        {
            return _context.Reseller.OrderBy(x => x.ResellerName).ToList();
        }
    }
}
