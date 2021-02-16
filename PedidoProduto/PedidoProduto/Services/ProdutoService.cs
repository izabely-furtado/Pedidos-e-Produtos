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

        public static List<Produto> ListarByNome(string filtro)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Produtos.Where(a => a.nome.IndexOf(filtro) >= 0)
                    .ToList();
            }
        }

        public static Produto Salvar(Produto produto_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                produto_.Validar();
                if (produto_.ID != 0)
                {
                    Produto _produto = ctx.Produtos.Where(x => x.ID.Equals(produto_.ID)).FirstOrDefault();

                    if (_produto != null && _produto.ID != 0)
                    {
                        return ProdutoService.Editar(_produto.ID, produto_);
                    }
                    //se possuir id !=0 e nao existente no banco.. nao seria novo nem editável
                    else
                    {
                        throw new ApplicationBadRequestException(ApplicationBadRequestException.ERRO_AO_CADASTRAR_CLIENTE);
                    }
                }
                else
                {
                    Produto produto = new Produto();
                    //produto.pedidos = produto_.pedidos;
                    produto.nome = produto_.nome;
                    ctx.Produtos.Add(produto);
                    ctx.SaveChanges();
                    return produto;
                }
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