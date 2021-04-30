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
    public class ComissionStatusController : Controller
    {
        private readonly SiberianSales2Context _context;

        public ComissionStatusController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: ComissionStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComissionStatus.ToListAsync());
        }

        // GET: ComissionStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionStatus = await _context.ComissionStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissionStatus == null)
            {
                return NotFound();
            }

            return View(comissionStatus);
        }

        // GET: ComissionStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComissionStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status")] ComissionStatus comissionStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comissionStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comissionStatus);
        }

        // GET: ComissionStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionStatus = await _context.ComissionStatus.FindAsync(id);
            if (comissionStatus == null)
            {
                return NotFound();
            }
            return View(comissionStatus);
        }

        // POST: ComissionStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] ComissionStatus comissionStatus)
        {
            if (id != comissionStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comissionStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComissionStatusExists(comissionStatus.Id))
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
            return View(comissionStatus);
        }

        // GET: ComissionStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissionStatus = await _context.ComissionStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissionStatus == null)
            {
                return NotFound();
            }

            return View(comissionStatus);
        }

        // POST: ComissionStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comissionStatus = await _context.ComissionStatus.FindAsync(id);
            _context.ComissionStatus.Remove(comissionStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComissionStatusExists(int id)
        {
            return _context.ComissionStatus.Any(e => e.Id == id);
        }
    }
}
