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
    public class FreightTypesController : Controller
    {
        private readonly SiberianSales2Context _context;

        public FreightTypesController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: FreightTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FreightTypes.ToListAsync());
        }

        // GET: FreightTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var freightTypes = await _context.FreightTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (freightTypes == null)
            {
                return NotFound();
            }

            return View(freightTypes);
        }

        // GET: FreightTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FreightTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FreightType")] FreightTypes freightTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(freightTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(freightTypes);
        }

        // GET: FreightTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var freightTypes = await _context.FreightTypes.FindAsync(id);
            if (freightTypes == null)
            {
                return NotFound();
            }
            return View(freightTypes);
        }

        // POST: FreightTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FreightType")] FreightTypes freightTypes)
        {
            if (id != freightTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(freightTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FreightTypesExists(freightTypes.Id))
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
            return View(freightTypes);
        }

        // GET: FreightTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var freightTypes = await _context.FreightTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (freightTypes == null)
            {
                return NotFound();
            }

            return View(freightTypes);
        }

        // POST: FreightTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var freightTypes = await _context.FreightTypes.FindAsync(id);
            _context.FreightTypes.Remove(freightTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FreightTypesExists(int id)
        {
            return _context.FreightTypes.Any(e => e.Id == id);
        }
    }
}
