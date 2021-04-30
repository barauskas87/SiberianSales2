using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Data;
using SiberianSales2.Models;

namespace SiberianSales2.Controllers
{
    public class ProposalItemsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public ProposalItemsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: ProposalItems
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.ProposalItem.Include(p => p.Product).Include(p => p.SalesProposal);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: ProposalItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalItem = await _context.ProposalItem
                .Include(p => p.Product)
                .Include(p => p.SalesProposal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposalItem == null)
            {
                return NotFound();
            }

            return View(proposalItem);
        }

        // GET: ProposalItems/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "PartNumber");
            ViewData["SalesProposalId"] = new SelectList(_context.SalesProposal, "Id", "Reference");
            return View();
        }

        // POST: ProposalItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,ProposalItemUnitValue,ProposalItemUnitCost,ProposalItemQtd,SalesProposalId")] ProposalItem proposalItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proposalItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "PartNumber", proposalItem.ProductId);
            ViewData["SalesProposalId"] = new SelectList(_context.SalesProposal, "Id", "Reference", proposalItem.SalesProposalId);
            return View(proposalItem);
        }

        // GET: ProposalItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalItem = await _context.ProposalItem.FindAsync(id);
            if (proposalItem == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "PartNumber", proposalItem.ProductId);
            ViewData["SalesProposalId"] = new SelectList(_context.SalesProposal, "Id", "Reference", proposalItem.SalesProposalId);
            return View(proposalItem);
        }

        // POST: ProposalItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,ProposalItemUnitValue,ProposalItemUnitCost,ProposalItemQtd,SalesProposalId")] ProposalItem proposalItem)
        {
            if (id != proposalItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposalItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProposalItemExists(proposalItem.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "PartNumber", proposalItem.ProductId);
            ViewData["SalesProposalId"] = new SelectList(_context.SalesProposal, "Id", "Reference", proposalItem.SalesProposalId);
            return View(proposalItem);
        }

        // GET: ProposalItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalItem = await _context.ProposalItem
                .Include(p => p.Product)
                .Include(p => p.SalesProposal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposalItem == null)
            {
                return NotFound();
            }

            return View(proposalItem);
        }

        // POST: ProposalItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proposalItem = await _context.ProposalItem.FindAsync(id);
            _context.ProposalItem.Remove(proposalItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProposalItemExists(int id)
        {
            return _context.ProposalItem.Any(e => e.Id == id);
        }
    }
}
