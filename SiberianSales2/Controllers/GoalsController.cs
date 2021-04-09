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
    public class GoalsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public GoalsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: Goals
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.Goals.Include(g => g.Seller);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: Goals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals
                .Include(g => g.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goals == null)
            {
                return NotFound();
            }

            return View(goals);
        }

        // GET: Goals/Create
        public IActionResult Create()
        {
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Id");
            return View();
        }

        // POST: Goals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BruteSales,LiquidSales,SalesCommission,Month,Year,SellerId")] Goals goals)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Id", goals.SellerId);
            return View(goals);
        }

        // GET: Goals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals.FindAsync(id);
            if (goals == null)
            {
                return NotFound();
            }
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Id", goals.SellerId);
            return View(goals);
        }

        // POST: Goals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BruteSales,LiquidSales,SalesCommission,Month,Year,SellerId")] Goals goals)
        {
            if (id != goals.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoalsExists(goals.Id))
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
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Id", goals.SellerId);
            return View(goals);
        }

        // GET: Goals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals
                .Include(g => g.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goals == null)
            {
                return NotFound();
            }

            return View(goals);
        }

        // POST: Goals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goals = await _context.Goals.FindAsync(id);
            _context.Goals.Remove(goals);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoalsExists(int id)
        {
            return _context.Goals.Any(e => e.Id == id);
        }
    }
}
