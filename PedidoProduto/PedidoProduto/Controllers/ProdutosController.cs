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
    public class ProdutosController : Controller
    {
        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController(ILogger<ProdutosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string pesquisar, int id, int produtoID, string produtoNome)
        {
            ViewData["Title"] = "Produtos";
            ViewData["IconTitle"] = "extension";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "";
            ViewData["ClassMenuProdutos"] = "menu-dsk";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "";
            this.Delete(id);
            this.Save(produtoID, produtoNome);
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
                this.ViewBag.produtos = ProdutoService.ListarByNome(pesquisar);
            }
            else
            {
                this.ViewBag.produtos = ProdutoService.Listar();
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
                ViewData["Title"] = "Editando Produto";
            }
            else
            {
                ViewData["Title"] = "Criando Produto";
            }
            ViewData["IconTitle"] = "extension";
            ViewData["ClassMenuHome"] = "";
            ViewData["ClassMenuClientes"] = "";
            ViewData["ClassMenuProdutos"] = "menu-dsk";
            ViewData["ClassMenuPedidos"] = "";
            ViewData["ClassMenuRelatorio"] = "";
            this.ViewBag.existError = false;
            this.ViewBag.msgError = "";
            this.ViewBag.existSucess = false;
            Produto cli = ProdutoService.Obter(id);
            if (cli == null)
            {
                this.ViewBag.produto = new Produto();
            }
            else
            {
                this.ViewBag.produto = ProdutoService.Obter(id);
            }
            return View();
        }

        public void Delete(int produto_ID)
        {
            try
            {
                if (produto_ID != 0)
                {
                    ProdutoService.Deletar(produto_ID);
                    this.ViewBag.existSucess = true;
                }
            }
            catch (Exception e)
            {
                this.ViewBag.existError = true;
                this.ViewBag.msgError = e;
            }
        }
        public void Save(int produtoID, string produtoNome)
        {
            try
            {
                if (produtoNome != "")
                {
                    Produto novo = new Produto();
                    novo.ID = produtoID;
                    novo.nome = produtoNome;
                    ProdutoService.Salvar(novo);
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
