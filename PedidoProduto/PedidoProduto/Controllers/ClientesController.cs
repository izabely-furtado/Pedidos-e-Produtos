using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedidoProduto.Entities;
using PedidoProduto.Models;
using PedidoProduto.Services;

namespace PedidoProduto.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        
        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Clientes";
            ViewData["IconTitle"] = "person";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "menu-dsk";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "";
            Cliente cli = new Cliente();
            cli.NOME = "testando2";
            Cliente retorno = ClienteService.Salvar(cli);
            ViewData["List"] = ClienteService.Listar()[0].NOME + retorno.NOME;

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
