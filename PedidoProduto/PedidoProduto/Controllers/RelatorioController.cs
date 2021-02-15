using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedidoProduto.Models;

namespace PedidoProduto.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly ILogger<RelatorioController> _logger;

        public RelatorioController(ILogger<RelatorioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Relatório";
            ViewData["IconTitle"] = "stacked_bar_chart";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "menu-dsk";
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
