using LinqKit;
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
    public class ClienteService
    {

        public static Cliente Obter(string id)
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Clientes.Include(a => a.pedidos)
                    .Where(a => a.id == id).FirstOrDefault();
            }
        }

        public static Cliente ObterApiCliente(int cliente_uuid, int uuid)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Cliente _cliente = ctx.Clientes.Where(a => a.id == cliente_uuid).FirstOrDefault();
                return ctx.Clientes
                    .Include(a => a.pedidos)
                    .Where(a => a.id == uuid).FirstOrDefault();
            }
        }

        public static List<Cliente> Listar()
        {
            using (Repositorio ctx = new Repositorio())
            {
                return ctx.Clientes.ToList();
            }
        }

        public static Cliente Salvar(Cliente cliente_)
        {
            using (Repositorio ctx = new Repositorio())
            {
                //cliente_.Validar();
                Cliente _cliente = ctx.Clientes.Where(x => x.cpf.Equals(cliente_.cpf)).FirstOrDefault();

                if (_cliente != null && _cliente.id != 0)
                {
                    return ClienteService.Editar(_cliente.id, cliente_);
                }
                //throw new ApplicationBadRequestException(ApplicationBadRequestException.ERRO_AO_CADASTRAR_PESSOA);

                RequisicaoHTTP requisicao = new RequisicaoHTTP();
                Cliente cliente = new Cliente();
                cliente.pedidos = cliente_.pedidos;

                ctx.Clientes.Add(cliente);
                ctx.SaveChanges();
                return cliente;
            }
        }

        public static Cliente Editar(int uuid, Cliente cliente)
        {
            using (Repositorio ctx = new Repositorio())
            {
                Cliente _cliente = ctx.Clientes
                    .Include(a => a.pedidos)
                    .Where(x => x.id == uuid).FirstOrDefault();
                _cliente.Validar();

                _cliente.nome = cliente.nome.ToUpper();
                _cliente.pedidos = cliente.pedidos;
                ctx.Clientes.Update(_cliente);
                

                ctx.SaveChanges();
                return _cliente;
            }
        }

        public static PaginacaoModel ListarPagina(int pagina)
        {
            using (Repositorio ctx = new Repositorio())
            {
                PaginacaoModel _pagina = new PaginacaoModel();

                _pagina.pagina_atual = (int)pagina;
                _pagina.quantidade_pagina = 10; //???
                int inicio = (pagina - 1) * _pagina.quantidade_pagina;

                List<Cliente> clientes = new List<Cliente>();
                _pagina.quantidade_total = ctx.Clientes.Count();
                clientes = ctx.Clientes.Include(a => a.pedidos)
                    .OrderBy(x => x.nome).Skip(inicio).Take(_pagina.quantidade_pagina).ToList();

                _pagina.total_paginas = Convert.ToInt32(Math.Ceiling((double)_pagina.quantidade_total / _pagina.quantidade_pagina));
                _pagina.conteudo = clientes;

                return _pagina;
            }
        }


        public static bool Deletar(string cliente_uuid)
        {
            List<Cliente> erros = new List<Cliente>();

            using (Repositorio ctx = new Repositorio())
            {
                Cliente _cliente = ctx.Clientes.Include(a => a.pedidos)
                    .Where(a => a.id == cliente_uuid).FirstOrDefault();

                if (_cliente == null)
                {
                    return true;
                }
                ctx.Clientes.Remove(_cliente);
                ctx.SaveChanges();
                return true;
            }
        }


    }
}