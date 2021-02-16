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
        public List<Cliente> clientes { get; set; }
        public Cliente cliente { get; set; }

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string pesquisar, int id, int clienteID, string clienteNome)
        {
            ViewData["Title"] = "Clientes";
            ViewData["IconTitle"] = "person";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "menu-dsk";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "";
            this.Delete(id);
            this.Save(clienteID, clienteNome);
            this.Search(pesquisar);
            this.ViewBag.pesquisa = "";
            this.ViewBag.existError = false;
            this.ViewBag.msgError = "";
            this.ViewBag.existSucess = false;
            return View();
        }
        public void Search(string pesquisar)
        {
            if (pesquisar != null && pesquisar != "")
            {
                this.ViewBag.clientes = ClienteService.ListarByNome(pesquisar);
            }
            else
            {
                this.ViewBag.clientes = ClienteService.Listar();
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
            if (id != 0) { 
                ViewData["Title"] = "Editando Cliente";
            }
            else
            {
                ViewData["Title"] = "Criando Cliente";
            }
            ViewData["IconTitle"] = "person";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "menu-dsk";
            ViewData["ClassMenuProdutos"] = "";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "";
            this.ViewBag.existError = false;
            this.ViewBag.msgError = "";
            this.ViewBag.existSucess = false;
            Cliente cli = ClienteService.Obter(id);
            if (cli == null)
            {
                this.ViewBag.cliente = new Cliente();
            }
            else {
                this.ViewBag.cliente = ClienteService.Obter(id);
            }
            this.cliente = this.ViewBag.cliente;
            return View();
        }

        public void Delete(int client_ID)
        {
            try
            {
                if (client_ID != 0)
                {
                    ClienteService.Deletar(client_ID);
                    this.ViewBag.existSucess = true;
                }
            }
            catch (Exception e)
            {
                this.ViewBag.existError = true;
                this.ViewBag.msgError = e;
            }
        }

        public ActionResult Back(Cliente item)
        {
            item.inEdition = false;
            item = ClienteService.Obter(item.ID);
            return View();
        }

        public void Save(int clienteID, string clienteNome)
        {
            try
            {
                if (clienteNome != "")
                {
                    Cliente novo = new Cliente();
                    novo.ID = clienteID;
                    novo.nome = clienteNome;
                    ClienteService.Salvar(novo);
                    this.ViewBag.existSucess = true;
                    novo.inEdition = false;
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
