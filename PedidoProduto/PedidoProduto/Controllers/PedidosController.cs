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
    public class PedidosController : Controller
    {
        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string pesquisar, int id, int pedidoID, int clientID)
        {
            ViewData["Title"] = "Pedidos";
            ViewData["IconTitle"] = "shopping_cart";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "menu-dsk";
            ViewData["ClassMenuRelatorio"] = "";
            this.Delete(id);
            this.Save(pedidoID, clientID);
            this.Search(pesquisar);
            this.ViewBag.pesquisa = "";
            this.ViewBag.existError = false;
            this.ViewBag.msgError = "";
            this.ViewBag.existSucess = false;
            this.ViewBag.clientes = ClienteService.Listar();
            return View();
        }
        public void Search(string pesquisar)
        {
            if (pesquisar != null && pesquisar != "")
            {
                this.ViewBag.pedidos = PedidoService.ListarByFilter(pesquisar);
            }
            else
            {
                this.ViewBag.pedidos = PedidoService.Listar();
            }
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

        public ActionResult Edit(int id)
        {
            if (id != 0)
            {
                ViewData["Title"] = "Editando Pedido";
            }
            else
            {
                ViewData["Title"] = "Criando Pedido";
            }
            ViewData["IconTitle"] = "shopping_cart";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "menu-dsk";
            ViewData["ClassMenuRelatorio"] = "";
            this.ViewBag.existError = false;
            this.ViewBag.msgError = "";
            this.ViewBag.existSucess = false;
            this.ViewBag.clientes = ClienteService.Listar();
            Pedido cli = PedidoService.Obter(id);
            if (cli == null)
            {
                this.ViewBag.pedido = new Pedido();
            }
            else
            {
                this.ViewBag.pedido = PedidoService.Obter(id);
            }
            return View();
        }

        public void Delete(int client_ID)
        {
            try
            {
                if (client_ID != 0)
                {
                    PedidoService.Deletar(client_ID);
                    this.ViewBag.existSucess = true;
                }
            }
            catch (Exception e)
            {
                this.ViewBag.existError = true;
                this.ViewBag.msgError = e;
            }
        }
        public void Save(int pedidoID, int clienteID)
        {
            try
            {
                if (clienteID != 0)
                {
                    Pedido novo = new Pedido();
                    novo.ID = pedidoID;
                    novo.Cliente = ClienteService.Obter(clienteID);
                    //data recebe momento atual cada vez q é modificada
                    novo.dataPedido = DateTime.Now;
                    //quantidade total é atrelada a produtos q é inserida em outro momento
                    PedidoService.Salvar(novo);
                    this.ViewBag.existSucess = true;
                }
            }
            catch (Exception e)
            {
                this.ViewBag.existError = true;
                this.ViewBag.msgError = e;
            }
        }
    }
}
