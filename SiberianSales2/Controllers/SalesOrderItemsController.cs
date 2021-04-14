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
    public class SalesOrderItemsController : Controller
    {
        private readonly SiberianSales2Context _context;

        public SalesOrderItemsController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: SalesOrderItems
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.SalesOrderItem.Include(s => s.SalesOrder);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: SalesOrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderItem = await _context.SalesOrderItem
                .Include(s => s.SalesOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrderItem == null)
            {
                return NotFound();
            }

            return View(salesOrderItem);
        }

        // GET: SalesOrderItems/Create
        public IActionResult Create()
        {
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Id");
            return View();
        }

        // POST: SalesOrderItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SoItemUnitValue,SoItemUnitCost,SoItemQtde,SalesOrderId")] SalesOrderItem salesOrderItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesOrderItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Id", salesOrderItem.SalesOrderId);
            return View(salesOrderItem);
        }

        // GET: SalesOrderItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderItem = await _context.SalesOrderItem.FindAsync(id);
            if (salesOrderItem == null)
            {
                return NotFound();
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Id", salesOrderItem.SalesOrderId);
            return View(salesOrderItem);
        }

        // POST: SalesOrderItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SoItemUnitValue,SoItemUnitCost,SoItemQtde,SalesOrderId")] SalesOrderItem salesOrderItem)
        {
            if (id != salesOrderItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesOrderItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesOrderItemExists(salesOrderItem.Id))
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
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrder, "Id", "Id", salesOrderItem.SalesOrderId);
            return View(salesOrderItem);
        }

        // GET: SalesOrderItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderItem = await _context.SalesOrderItem
                .Include(s => s.SalesOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesOrderItem == null)
            {
                return NotFound();
            }

            return View(salesOrderItem);
        }

        // POST: SalesOrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesOrderItem = await _context.SalesOrderItem.FindAsync(id);
            _context.SalesOrderItem.Remove(salesOrderItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesOrderItemExists(int id)
        {
            return _context.SalesOrderItem.Any(e => e.Id == id);
        }
    }
}
