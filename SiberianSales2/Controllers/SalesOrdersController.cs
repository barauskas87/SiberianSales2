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
    public class SalesOrdersController : Controller
    {
        private readonly SiberianSales2Context _context;

        public SalesOrdersController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: SalesOrders
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.SalesOrder.Include(s => s.Client).Include(s => s.SalesOrderStatus).Include(s => s.Seller);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: SalesOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrder = await _context.SalesOrder
                .Include(s => s.Client)
                .Include(s => s.SalesOrderStatus)
                .Include(s => s.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrder);
        }

        // GET: SalesOrders/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id");
            ViewData["SalesOrderStatusId"] = new SelectList(_context.SalesOrderStatus, "Id", "Id");
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Email");
            return View();
        }

        // POST: SalesOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SellerId,ClientId,Reference,OrderDate,SendingDate,FiscalCupom,TrackingId,FreightTypeId,FreightValue,Observation,ResellerFiscalCupom,ResellerFiscalCupomDate,SalesOrderStatusId,SalesOrderTotalValue,SalesOrderComission")] SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", salesOrder.ClientId);
            ViewData["SalesOrderStatusId"] = new SelectList(_context.SalesOrderStatus, "Id", "Id", salesOrder.SalesOrderStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Email", salesOrder.SellerId);
            return View(salesOrder);
        }

        // GET: SalesOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrder = await _context.SalesOrder.FindAsync(id);
            if (salesOrder == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", salesOrder.ClientId);
            ViewData["SalesOrderStatusId"] = new SelectList(_context.SalesOrderStatus, "Id", "Id", salesOrder.SalesOrderStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Email", salesOrder.SellerId);
            return View(salesOrder);
        }

        // POST: SalesOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SellerId,ClientId,Reference,OrderDate,SendingDate,FiscalCupom,TrackingId,FreightTypeId,FreightValue,Observation,ResellerFiscalCupom,ResellerFiscalCupomDate,SalesOrderStatusId,SalesOrderTotalValue,SalesOrderComission")] SalesOrder salesOrder)
        {
            if (id != salesOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesOrderExists(salesOrder.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", salesOrder.ClientId);
            ViewData["SalesOrderStatusId"] = new SelectList(_context.SalesOrderStatus, "Id", "Id", salesOrder.SalesOrderStatusId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Email", salesOrder.SellerId);
            return View(salesOrder);
        }

        // GET: SalesOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrder = await _context.SalesOrder
                .Include(s => s.Client)
                .Include(s => s.SalesOrderStatus)
                .Include(s => s.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            return View(salesOrder);
        }

        // POST: SalesOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesOrder = await _context.SalesOrder.FindAsync(id);
            _context.SalesOrder.Remove(salesOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesOrderExists(int id)
        {
            return _context.SalesOrder.Any(e => e.Id == id);
        }
    }
}
