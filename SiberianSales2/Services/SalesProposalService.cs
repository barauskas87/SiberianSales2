using System;
using System.Collections.Generic;
using System.Linq;
using SiberianSales2.Data;
using SiberianSales2.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace SiberianSales2.Services
{
    public class SalesProposalService
    {
        private readonly SiberianSales2Context _context;

        public SalesProposalService(SiberianSales2Context context)
        {
            _context = context;
        }

        public async Task<List<SalesProposal>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesProposal select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.ProposalDate >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.ProposalDate <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller.Name)
                .Include(x => x.Seller.Department)
                .Include(x => x.Client.ClientFantasyName)
                .OrderByDescending(x => x.ProposalDate)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Client, SalesProposal>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesProposal select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.ProposalDate >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.ProposalDate <= maxDate.Value);
            }
            return await result
                 .Include(x => x.Seller.Name)
                 .Include(x => x.Seller.Department)
                 .Include(x => x.Client.ClientFantasyName)
                 .OrderByDescending(x => x.ProposalDate)
                 .GroupBy(keySelector: x => x.Client)
                 .ToListAsync();
        }
    }
}
