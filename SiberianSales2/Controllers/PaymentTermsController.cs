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
    public class PaymentTermsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public PaymentTermsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: PaymentTerms
        public async Task<IActionResult> Index()
        {
            return View(await _context.PaymentTerms.ToListAsync());
        }

        // GET: PaymentTerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentTerms = await _context.PaymentTerms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentTerms == null)
            {
                return NotFound();
            }

            return View(paymentTerms);
        }

        // GET: PaymentTerms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PaymentTerm,PaymentTermDays,PaymentDuplicates")] PaymentTerms paymentTerms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentTerms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentTerms);
        }

        // GET: PaymentTerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentTerms = await _context.PaymentTerms.FindAsync(id);
            if (paymentTerms == null)
            {
                return NotFound();
            }
            return View(paymentTerms);
        }

        // POST: PaymentTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PaymentTerm,PaymentTermDays,PaymentDuplicates")] PaymentTerms paymentTerms)
        {
            if (id != paymentTerms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentTerms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentTermsExists(paymentTerms.Id))
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
            return View(paymentTerms);
        }

        // GET: PaymentTerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentTerms = await _context.PaymentTerms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentTerms == null)
            {
                return NotFound();
            }

            return View(paymentTerms);
        }

        // POST: PaymentTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentTerms = await _context.PaymentTerms.FindAsync(id);
            _context.PaymentTerms.Remove(paymentTerms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentTermsExists(int id)
        {
            return _context.PaymentTerms.Any(e => e.Id == id);
        }
    }
}
