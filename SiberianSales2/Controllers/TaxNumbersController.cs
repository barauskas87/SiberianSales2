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
    public class TaxNumbersController : Controller
    {
        private readonly SiberianSales2Context _context;

        public TaxNumbersController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: TaxNumbers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaxNumber.ToListAsync());
        }

        // GET: TaxNumbers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxNumber = await _context.TaxNumber
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taxNumber == null)
            {
                return NotFound();
            }

            return View(taxNumber);
        }

        // GET: TaxNumbers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaxNumbers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ncm,Ipi")] TaxNumber taxNumber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taxNumber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taxNumber);
        }

        // GET: TaxNumbers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxNumber = await _context.TaxNumber.FindAsync(id);
            if (taxNumber == null)
            {
                return NotFound();
            }
            return View(taxNumber);
        }

        // POST: TaxNumbers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ncm,Ipi")] TaxNumber taxNumber)
        {
            if (id != taxNumber.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taxNumber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaxNumberExists(taxNumber.Id))
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
            return View(taxNumber);
        }

        // GET: TaxNumbers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxNumber = await _context.TaxNumber
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taxNumber == null)
            {
                return NotFound();
            }

            return View(taxNumber);
        }

        // POST: TaxNumbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taxNumber = await _context.TaxNumber.FindAsync(id);
            _context.TaxNumber.Remove(taxNumber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaxNumberExists(int id)
        {
            return _context.TaxNumber.Any(e => e.Id == id);
        }
    }
}
