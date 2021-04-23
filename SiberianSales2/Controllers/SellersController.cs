using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Data;
using SiberianSales2.Models;
using SiberianSales2.Models.ViewModels;

namespace SiberianSales2.Controllers
{
    public class SellersController : Controller
    {
        private readonly SiberianSales2Context _context;

        public SellersController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: Sellers
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.Seller.Include(s => s.Department).Include(s => s.Reseller);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: Sellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof (Error), new { message = "Id not provided" });
            }

            var seller = await _context.Seller
                .Include(s => s.Department)
                .Include(s => s.Reseller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seller == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Seller not found" });
            }

            return View(seller);
        }

        // GET: Sellers/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Name");
            ViewData["ResellerId"] = new SelectList(_context.Reseller, "Id", "ResellerName");
            return View();
        }

        // POST: Sellers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Phone,Phone2,Email,Skype,Linkedin,Facebook,Tweeter,BirthDate,TxCommission,BaseSalary,DepartmentId,ResellerId")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Name", seller.DepartmentId);
            ViewData["ResellerId"] = new SelectList(_context.Reseller, "Id", "ResellerName", seller.ResellerId);
            return View(seller);
        }

        // GET: Sellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" }); 
            }

            var seller = await _context.Seller.FindAsync(id);
            if (seller == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Seller not found" });
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Name", seller.DepartmentId);
            ViewData["ResellerId"] = new SelectList(_context.Reseller, "Id", "ResellerName", seller.ResellerId);
            return View(seller);
        }

        // POST: Sellers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Phone,Phone2,Email,Skype,Linkedin,Facebook,Tweeter,BirthDate,TxCommission,BaseSalary,DepartmentId,ResellerId")] Seller seller)
        {
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Selected ID does not match with the ID edited" });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellerExists(seller.Id))
                    {
                        return RedirectToAction(nameof(Error), new { message = "Seller do not exist" });                   }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Name", seller.DepartmentId);
            ViewData["ResellerId"] = new SelectList(_context.Reseller, "Id", "ResellerName", seller.ResellerId);
            return View(seller);
        }

        // GET: Sellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Seller not found" });
            }

            var seller = await _context.Seller
                .Include(s => s.Department)
                .Include(s => s.Reseller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seller == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Seller do not exist" });
            }

            return View(seller);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seller = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellerExists(int id)
        {
            return _context.Seller.Any(e => e.Id == id);
        }

        public IActionResult Error(string message)
        {
            var ViewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(ViewModel);
        }
    }
}
