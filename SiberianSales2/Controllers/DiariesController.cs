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
    public class DiariesController : Controller
    {
        private readonly SiberianSales2Context _context;

        public DiariesController(SiberianSales2Context context)
        {
            _context = context;
        }

        // GET: Diaries
        public async Task<IActionResult> Index()
        {
            var siberianSales2Context = _context.Diary.Include(d => d.Client).Include(d => d.Seller);
            return View(await siberianSales2Context.ToListAsync());
        }

        // GET: Diaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diary = await _context.Diary
                .Include(d => d.Client)
                .Include(d => d.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diary == null)
            {
                return NotFound();
            }

            return View(diary);
        }

        // GET: Diaries/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientName");
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name");
            return View();
        }

        // POST: Diaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SellerId,ClientId,RealizationDate,Content")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientName", diary.ClientId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", diary.SellerId);
            return View(diary);
        }

        // GET: Diaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diary = await _context.Diary.FindAsync(id);
            if (diary == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientName", diary.ClientId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", diary.SellerId);
            return View(diary);
        }

        // POST: Diaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SellerId,ClientId,RealizationDate,Content")] Diary diary)
        {
            if (id != diary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiaryExists(diary.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "ClientName", diary.ClientId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "Id", "Name", diary.SellerId);
            return View(diary);
        }

        // GET: Diaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diary = await _context.Diary
                .Include(d => d.Client)
                .Include(d => d.Seller)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diary == null)
            {
                return NotFound();
            }

            return View(diary);
        }

        // POST: Diaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diary = await _context.Diary.FindAsync(id);
            _context.Diary.Remove(diary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiaryExists(int id)
        {
            return _context.Diary.Any(e => e.Id == id);
        }
    }
}
