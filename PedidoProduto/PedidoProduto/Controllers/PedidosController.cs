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
    public class PedidosController : Controller
    {
        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Pedidos";
            ViewData["IconTitle"] = "shopping_cart";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "menu-dsk";
            ViewData["ClassMenuRelatorio"] = "";
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
