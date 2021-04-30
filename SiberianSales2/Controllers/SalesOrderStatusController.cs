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
    public class SalesOrderStatusController : Controller
    {
        private readonly SiberianSales2Context _context;

        public SalesOrderStatusController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: SalesOrderStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.SalesOrderStatus.ToListAsync());
        }

        // GET: SalesOrderStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderStatus = await _context.SalesOrderStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrderStatus == null)
            {
                return NotFound();
            }

            return View(salesOrderStatus);
        }

        // GET: SalesOrderStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesOrderStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status")] SalesOrderStatus salesOrderStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesOrderStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesOrderStatus);
        }

        // GET: SalesOrderStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderStatus = await _context.SalesOrderStatus.FindAsync(id);
            if (salesOrderStatus == null)
            {
                return NotFound();
            }
            return View(salesOrderStatus);
        }

        // POST: SalesOrderStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] SalesOrderStatus salesOrderStatus)
        {
            if (id != salesOrderStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesOrderStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesOrderStatusExists(salesOrderStatus.Id))
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
            return View(salesOrderStatus);
        }

        // GET: SalesOrderStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderStatus = await _context.SalesOrderStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrderStatus == null)
            {
                return NotFound();
            }

            return View(salesOrderStatus);
        }

        // POST: SalesOrderStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesOrderStatus = await _context.SalesOrderStatus.FindAsync(id);
            _context.SalesOrderStatus.Remove(salesOrderStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesOrderStatusExists(int id)
        {
            return _context.SalesOrderStatus.Any(e => e.Id == id);
        }
    }
}
