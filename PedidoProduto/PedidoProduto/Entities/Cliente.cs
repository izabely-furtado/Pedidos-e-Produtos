using System.ComponentModel.DataAnnotations.Schema;
using PedidoProduto.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PedidoProduto.Entities
{
    public class Cliente : Entity
    {
        public string NOME { get; set; }

        public virtual List<Pedido> pedidos { get; set; }

        public void Validar()
        {
            if (String.IsNullOrEmpty(this.NOME))
                throw new ApplicationBadRequestException(ApplicationBadRequestException.NOME_INVALIDO);

            if (this.pedidos != null && this.pedidos.Count > 0)
            {
                List<Pedido> lista = new List<Pedido>();
                foreach (var item in this.pedidos)
                {
                    Pedido pedido = lista.Where(x => x.ID == item.ID).FirstOrDefault();
                    if (pedido == null)
                    {
                        lista.Add(item);
                    }
                }
                this.pedidos = lista;
            }
        }
    
    }
}
