using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Data;
using SiberianSales2.Models;
using SiberianSales2.Services;

namespace SiberianSales2.Controllers
{
    public class SalesProposalsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public SalesProposalsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: SalesProposals
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.SalesProposal.Include(s => s.Client).Include(s => s.ProposalStatus).Include(s => s.Seller);
            return View(await siberianSales2Context.ToListAsync());
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime?maxDate)
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }

        // GET: SalesProposals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesProposal = await _context.SalesProposal
                .Include(s => s.Client)
                .Include(s => s.ProposalStatus)
                .Include(s => s.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesProposal == null)
            {
                return NotFound();
            }

            return View(salesProposal);
        }

        // GET: SalesProposals/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientFantasyName");
            ViewData["ProposalStatusId"] = new SelectList(_context.ProposalStatus, "Id", "Status");
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name");
            return View();
        }

        // POST: SalesProposals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Reference,SellerId,ClientId,ProposalDate,ProposalValidity,FreightValue,ProposalStatusId,Observations,ProposalValue,ProposalComissionValue")] SalesProposal salesProposal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesProposal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientFantasyName", salesProposal.ClientId);
            ViewData["ProposalStatusId"] = new SelectList(_context.ProposalStatus, "Id", "Status", salesProposal.ProposalStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", salesProposal.SellerId);
            return View(salesProposal);
        }

        // GET: SalesProposals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesProposal = await _context.SalesProposal.FindAsync(id);
            if (salesProposal == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientFantasyName", salesProposal.ClientId);
            ViewData["ProposalStatusId"] = new SelectList(_context.ProposalStatus, "Id", "Status", salesProposal.ProposalStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", salesProposal.SellerId);
            return View(salesProposal);
        }

        // POST: SalesProposals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Reference,SellerId,ClientId,ProposalDate,ProposalValidity,FreightValue,ProposalStatusId,Observations,ProposalValue,ProposalComissionValue")] SalesProposal salesProposal)
        {
            if (id != salesProposal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesProposal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesProposalExists(salesProposal.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientFantasyName", salesProposal.ClientId);
            ViewData["ProposalStatusId"] = new SelectList(_context.ProposalStatus, "Id", "Status", salesProposal.ProposalStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", salesProposal.SellerId);
            return View(salesProposal);
        }

        // GET: SalesProposals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesProposal = await _context.SalesProposal
                .Include(s => s.Client)
                .Include(s => s.ProposalStatus)
                .Include(s => s.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesProposal == null)
            {
                return NotFound();
            }

            return View(salesProposal);
        }

        // POST: SalesProposals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesProposal = await _context.SalesProposal.FindAsync(id);
            _context.SalesProposal.Remove(salesProposal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesProposalExists(int id)
        {
            return _context.SalesProposal.Any(e => e.Id == id);
        }
    }
}
