using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Data;
using SiberianSales2.Models;
using SiberianSales2.Services;
using SiberianSales2.Models.ViewModels;

namespace SiberianSales2.Controllers
{
    public class ResellersController : Controller
    {
        private readonly SiberianSales2Context _context;
        private readonly AddressService _addressService;

        public ResellersController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: Resellers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reseller.ToListAsync());
        }

        // GET: Resellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reseller = await _context.Reseller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reseller == null)
            {
                return NotFound();
            }

            return View(reseller);
        }

        // GET: Resellers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resellers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ResellerName,ResellerFantasyName,ResellerCnpj,StateInscription,StateInscriptionExemption,MunicipalInscription,Phone,Website,TxComissionRetention,Observation")] Reseller reseller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reseller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reseller);
        }

        // GET: Resellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reseller = await _context.Reseller.FindAsync(id);
            if (reseller == null)
            {
                return NotFound();
            }
            return View(reseller);
        }

        // POST: Resellers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ResellerName,ResellerFantasyName,ResellerCnpj,StateInscription,StateInscriptionExemption,MunicipalInscription,Phone,Website,TxComissionRetention,Observation")] Reseller reseller)
        {
            if (id != reseller.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reseller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResellerExists(reseller.Id))
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
            return View(reseller);
        }

        // GET: Resellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reseller = await _context.Reseller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reseller == null)
            {
                return NotFound();
            }

            return View(reseller);
        }

        // POST: Resellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reseller = await _context.Reseller.FindAsync(id);
            _context.Reseller.Remove(reseller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResellerExists(int id)
        {
            return _context.Reseller.Any(e => e.Id == id);
        }
    }
}
