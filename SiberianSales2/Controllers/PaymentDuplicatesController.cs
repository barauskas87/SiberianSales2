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
    public class PaymentDuplicatesController : Controller
    {
        private readonly SiberianSales2Context _context;

        public PaymentDuplicatesController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: PaymentDuplicates
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.PaymentDuplicate.Include(p => p.SalesOrder);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: PaymentDuplicates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentDuplicate = await _context.PaymentDuplicate
                .Include(p => p.SalesOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentDuplicate == null)
            {
                return NotFound();
            }

            return View(paymentDuplicate);
        }

        // GET: PaymentDuplicates/Create
        public IActionResult Create()
        {
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Reference");
            return View();
        }

        // POST: PaymentDuplicates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DuplicateValue,PayDate,SalesOrderId")] PaymentDuplicate paymentDuplicate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentDuplicate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Reference", paymentDuplicate.SalesOrderId);
            return View(paymentDuplicate);
        }

        // GET: PaymentDuplicates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentDuplicate = await _context.PaymentDuplicate.FindAsync(id);
            if (paymentDuplicate == null)
            {
                return NotFound();
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Reference", paymentDuplicate.SalesOrderId);
            return View(paymentDuplicate);
        }

        // POST: PaymentDuplicates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DuplicateValue,PayDate,SalesOrderId")] PaymentDuplicate paymentDuplicate)
        {
            if (id != paymentDuplicate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentDuplicate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentDuplicateExists(paymentDuplicate.Id))
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
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Reference", paymentDuplicate.SalesOrderId);
            return View(paymentDuplicate);
        }

        // GET: PaymentDuplicates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentDuplicate = await _context.PaymentDuplicate
                .Include(p => p.SalesOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentDuplicate == null)
            {
                return NotFound();
            }

            return View(paymentDuplicate);
        }

        // POST: PaymentDuplicates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentDuplicate = await _context.PaymentDuplicate.FindAsync(id);
            _context.PaymentDuplicate.Remove(paymentDuplicate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentDuplicateExists(int id)
        {
            return _context.PaymentDuplicate.Any(e => e.Id == id);
        }
    }
}
