using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            return _context.Reseller.ToList();
        }

        public async Task<List<Reseller>> FindAllAsync()
        {
            return await _context.Reseller.ToListAsync();
        }
    }
}
