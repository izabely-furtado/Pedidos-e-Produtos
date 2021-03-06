﻿using PedidoProduto.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PedidoProduto.Entities
{
    public class Pedido : Entity
    {
        public DateTime dataPedido {get ; set; }
        public Single total { get; set; }

        [ForeignKey("CLIENTE")]
        public virtual Cliente Cliente { get; set; }

        public virtual List<Produto> produtos { get; set; }

        public void Validar()
        {
            if (this.dataPedido == null)
                throw new ApplicationBadRequestException(ApplicationBadRequestException.DATA_INVALIDA);

            if (Single.IsNaN(this.total) || Single.IsNegative(this.total))
                throw new ApplicationBadRequestException(ApplicationBadRequestException.TOTAL_INVALIDO);
            
            if (this.produtos != null && this.produtos.Count > 0)
            {
                List<Produto> lista = new List<Produto>();
                foreach (var item in this.produtos)
                {
                    Produto produto = lista.Where(x => x.ID == item.ID).FirstOrDefault();
                    if (produto == null)
                    {
                        lista.Add(item);
                    }
                }
                this.produtos = lista;
            }
            
            
        }
    }
}
