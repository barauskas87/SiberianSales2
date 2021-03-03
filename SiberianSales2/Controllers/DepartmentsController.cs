using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models;

namespace SiberianSales2.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Hardware" });
            list.Add(new Department {Id = 2, Name = "Services" });
            list.Add(new Department {Id = 3, Name = "Software" });

            return View(list);
        }
    }
}
