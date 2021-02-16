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
                return ctx.Pedidos.Include(a => a.Cliente).ToList();
            }
        }

        public static List<Pedido> Listar(int client_id)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Pedidos.Include(a => a.Cliente).Where(a => a.Cliente.ID == client_id).ToList();
            }
        }

        public static Pedido Salvar(Pedido pedido_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                pedido_.Validar();
                Pedido _pessoa = ctx.Pedidos.Where(x => x.ID.Equals(pedido_.ID)).FirstOrDefault();

                ctx.Pedidos.Add(pedido_);
                ctx.SaveChanges();
                return pedido_;
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

                ctx.Remove(_pedido);
                ctx.SaveChanges();

                return true;
            }
        }


        //// se der tempo fazer pedido por periodo para a geração dos relatórios

    }
}