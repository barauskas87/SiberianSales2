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
    public class PurchaseOrderStatusController : Controller
    {
        private readonly SiberianSales2Context _context;

        public PurchaseOrderStatusController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: PurchaseOrderStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.PurchaseOrderStatus.ToListAsync());
        }

        // GET: PurchaseOrderStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderStatus = await _context.PurchaseOrderStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            return View(purchaseOrderStatus);
        }

        // GET: PurchaseOrderStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseOrderStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status")] PurchaseOrderStatus purchaseOrderStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrderStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseOrderStatus);
        }

        // GET: PurchaseOrderStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderStatus = await _context.PurchaseOrderStatus.FindAsync(id);
            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }
            return View(purchaseOrderStatus);
        }

        // POST: PurchaseOrderStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] PurchaseOrderStatus purchaseOrderStatus)
        {
            if (id != purchaseOrderStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrderStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderStatusExists(purchaseOrderStatus.Id))
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
            return View(purchaseOrderStatus);
        }

        // GET: PurchaseOrderStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderStatus = await _context.PurchaseOrderStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            return View(purchaseOrderStatus);
        }

        // POST: PurchaseOrderStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseOrderStatus = await _context.PurchaseOrderStatus.FindAsync(id);
            _context.PurchaseOrderStatus.Remove(purchaseOrderStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderStatusExists(int id)
        {
            return _context.PurchaseOrderStatus.Any(e => e.Id == id);
        }
    }
}
