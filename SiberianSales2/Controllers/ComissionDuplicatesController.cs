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
    public class ComissionDuplicatesController : Controller
    {
        private readonly SiberianSales2Context _context;

        public ComissionDuplicatesController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: ComissionDuplicates
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComissionDuplicate.ToListAsync());
        }

        // GET: ComissionDuplicates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionDuplicate = await _context.ComissionDuplicate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissionDuplicate == null)
            {
                return NotFound();
            }

            return View(comissionDuplicate);
        }

        // GET: ComissionDuplicates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComissionDuplicates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ComissionDuplicateValue,AvaliableDate,Status")] ComissionDuplicate comissionDuplicate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comissionDuplicate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comissionDuplicate);
        }

        // GET: ComissionDuplicates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionDuplicate = await _context.ComissionDuplicate.FindAsync(id);
            if (comissionDuplicate == null)
            {
                return NotFound();
            }
            return View(comissionDuplicate);
        }

        // POST: ComissionDuplicates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ComissionDuplicateValue,AvaliableDate,Status")] ComissionDuplicate comissionDuplicate)
        {
            if (id != comissionDuplicate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comissionDuplicate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComissionDuplicateExists(comissionDuplicate.Id))
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
            return View(comissionDuplicate);
        }

        // GET: ComissionDuplicates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionDuplicate = await _context.ComissionDuplicate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissionDuplicate == null)
            {
                return NotFound();
            }

            return View(comissionDuplicate);
        }

        // POST: ComissionDuplicates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comissionDuplicate = await _context.ComissionDuplicate.FindAsync(id);
            _context.ComissionDuplicate.Remove(comissionDuplicate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComissionDuplicateExists(int id)
        {
            return _context.ComissionDuplicate.Any(e => e.Id == id);
        }
    }
}
