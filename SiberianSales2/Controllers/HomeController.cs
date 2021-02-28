using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiberianSales2.Models;

namespace SiberianSales2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sobre o Siberian Sales 2.0";
            ViewData["criador"] = "criado por: Victor Barauskas";
            ViewData["sobre"] = "O Siberian Sales 2.0 foi criado para suprir a necessidade de organizar e dinamizar o processo de vendas por representação dentro do sistema de distribuidor x revenda. Nosso sistema foi pensado para atender as revendas de informática que trabalham com comissionamento sobre vendas indiretas, com a gestão de pedidos, comissões, clientes e também de contatos e eventos, para facilitar o dia a dia de nossos vendedores."; 

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
