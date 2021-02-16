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
    public class PedidoService
    {

        public static Pedido Obter(int uuid)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Pedidos.Include(a => a.Cliente)
                                  .Where(a => a.ID == uuid)
                                  .FirstOrDefault();
            }
        }

        

        public static List<Pedido> Listar()
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Pedidos.Include(a => a.Cliente)
                    //.Include(a => a.produtos)
                    .ToList();
            }
        }

        public static List<Pedido> ListarByFilter(string filtro)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Pedidos
                    .Include(a => a.Cliente)
                    //.Include(a => a.produtos)
                    .Where(a => a.Cliente.nome.IndexOf(filtro) >= 0 || 
                                a.dataPedido.ToString() == filtro || 
                                a.total.ToString().Equals(filtro))
                    .ToList();
            }
        }

        public static List<Pedido> Listar(int client_id)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Pedidos.Include(a => a.Cliente).Where(a => a.Cliente.ID == client_id).ToList();
            }
        }

        public static List<PedidoProdutoE> ListarForProduct(int product_id)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return null;// ctx.PedidoProdutos.Include(a => a.Produto).Where(a => a.Produto.ID == product_id).ToList();
            }
        }

        public static List<PedidoProdutoE> ListarForPedido(int pedido_id)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return null;// ctx.PedidoProdutos.Include(a => a.Pedido).Where(a => a.Pedido.ID == pedido_id).ToList();
            }
        }

        public static Pedido Salvar(Pedido pedido_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                pedido_.Validar();
                if (pedido_.ID != 0)
                {
                    Pedido _pessoa = ctx.Pedidos.Where(x => x.ID.Equals(pedido_.ID)).FirstOrDefault();
                    if (_pessoa != null && _pessoa.ID != 0)
                    {
                        return PedidoService.Editar(_pessoa.ID, pedido_);
                    }
                    //se possuir id !=0 e nao existente no banco.. nao seria novo nem editável
                    else
                    {
                        throw new ApplicationBadRequestException(ApplicationBadRequestException.ERRO_AO_CADASTRAR_PEDIDO);
                    }
                }
                else
                {
                    Pedido pedido = new Pedido();
                    //pedido.produtos = pedido_.produtos;
                    pedido.Cliente = ClienteService.Obter(pedido_.Cliente.ID);
                    pedido.dataPedido = pedido_.dataPedido;
                    ctx.Pedidos.AddAsync(pedido);
                    ctx.SaveChanges();
                    return pedido;
                }
            }
        }

        public static Pedido Editar(int uuid, Pedido pedido_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Pedido _pedido = ctx.Pedidos.Where(x => x.ID == uuid).FirstOrDefault();
                _pedido.Validar();

                _pedido.dataPedido = pedido_.dataPedido;
                _pedido.total = pedido_.total;
                _pedido.Cliente = pedido_.Cliente;
                ctx.Pedidos.Update(_pedido);

                ctx.SaveChanges();
                return _pedido;
            }
        }


        


        public static bool Deletar(int uuid)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Pedido _pedido = ctx.Pedidos
                    .Where(s => s.ID == uuid).FirstOrDefault();

                if (_pedido == null)
                    return true;

                //deletar pedidos vinculados  a produtos
                List<PedidoProdutoE> pedidosProd = PedidoService.ListarForPedido(uuid);
                foreach (PedidoProdutoE pedProd in pedidosProd)
                {
                    ctx.Remove(pedProd);
                }

                ctx.Remove(_pedido);
                ctx.SaveChanges();

                return true;
            }
        }



        //// se der tempo fazer pedido por periodo para a geração dos relatórios

    }
}