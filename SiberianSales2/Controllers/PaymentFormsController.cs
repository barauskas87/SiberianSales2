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
    public class PaymentFormsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public PaymentFormsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: PaymentForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.PaymentForms.ToListAsync());
        }

        // GET: PaymentForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentForms = await _context.PaymentForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentForms == null)
            {
                return NotFound();
            }

            return View(paymentForms);
        }

        // GET: PaymentForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PaymentForm")] PaymentForms paymentForms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentForms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentForms);
        }

        // GET: PaymentForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentForms = await _context.PaymentForms.FindAsync(id);
            if (paymentForms == null)
            {
                return NotFound();
            }
            return View(paymentForms);
        }

        // POST: PaymentForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PaymentForm")] PaymentForms paymentForms)
        {
            if (id != paymentForms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentForms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentFormsExists(paymentForms.Id))
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
            return View(paymentForms);
        }

        // GET: PaymentForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentForms = await _context.PaymentForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentForms == null)
            {
                return NotFound();
            }

            return View(paymentForms);
        }

        // POST: PaymentForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentForms = await _context.PaymentForms.FindAsync(id);
            _context.PaymentForms.Remove(paymentForms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentFormsExists(int id)
        {
            return _context.PaymentForms.Any(e => e.Id == id);
        }
    }
}
