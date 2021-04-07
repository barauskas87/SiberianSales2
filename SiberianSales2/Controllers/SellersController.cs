﻿using System;
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
    public class SellersController : Controller
    {
        private readonly SiberianSales2Context _context;
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        private readonly ResellerService _resellerService;

        public SellersController(SiberianSales2Context context)
        {
            _context = context;
        }

        public SellersController(SellerService sellerService, DepartmentService departmentService, ResellerService resellerService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
            _resellerService = resellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var resellers = _resellerService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments, Resellers = resellers };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }
    }
}
