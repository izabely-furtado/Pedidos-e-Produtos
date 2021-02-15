using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PedidoProduto.Entities;
using PedidoProduto.Models;
using PedidoProduto.Persistencia;
using PedidoProduto.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PedidoProduto.Services
{
    public class ProdutoService
    {

        public static Produto Obter(int uuid)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Produtos.Where(a => a.ID == uuid)
                                  .FirstOrDefault();
            }
        }

        public static List<Produto> Listar()
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Produtos.ToList();
            }
        }

        public static Produto salvar(Produto produto_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                produto_.Validar();
                Produto _pessoa = ctx.Produtos.Where(x => x.ID.Equals(produto_.ID)).FirstOrDefault();

                ctx.Produtos.Add(produto_);
                ctx.SaveChanges();
                return produto_;
            }
        }

        public static Produto Editar(int uuid, Produto produto_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Produto _produto = ctx.Produtos
                    .Where(x => x.ID == uuid).FirstOrDefault();
                _produto.Validar();

                _produto.nome = produto_.nome.ToUpper();
                ctx.Produtos.Update(_produto);
                

                ctx.SaveChanges();
                return _produto;
            }
        }

        public static bool Deletar(int uuid)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Produto _produto = ctx.Produtos
                    .Where(s => s.ID == uuid).FirstOrDefault();

                if (_produto == null)
                    return true;

                ctx.Remove(_produto);
                ctx.SaveChanges();

                return true;
            }
        }

    }
}