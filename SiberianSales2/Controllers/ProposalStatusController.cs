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
    public class ProposalStatusController : Controller
    {
        private readonly SiberianSales2Context _context;

        public ProposalStatusController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: ProposalStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProposalStatus.ToListAsync());
        }

        // GET: ProposalStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalStatus = await _context.ProposalStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposalStatus == null)
            {
                return NotFound();
            }

            return View(proposalStatus);
        }

        // GET: ProposalStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProposalStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status")] ProposalStatus proposalStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proposalStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proposalStatus);
        }

        // GET: ProposalStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalStatus = await _context.ProposalStatus.FindAsync(id);
            if (proposalStatus == null)
            {
                return NotFound();
            }
            return View(proposalStatus);
        }

        // POST: ProposalStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] ProposalStatus proposalStatus)
        {
            if (id != proposalStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposalStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProposalStatusExists(proposalStatus.Id))
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
            return View(proposalStatus);
        }

        // GET: ProposalStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposalStatus = await _context.ProposalStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposalStatus == null)
            {
                return NotFound();
            }

            return View(proposalStatus);
        }

        // POST: ProposalStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proposalStatus = await _context.ProposalStatus.FindAsync(id);
            _context.ProposalStatus.Remove(proposalStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProposalStatusExists(int id)
        {
            return _context.ProposalStatus.Any(e => e.Id == id);
        }
    }
}
