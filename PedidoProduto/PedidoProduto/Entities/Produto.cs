using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PedidoProduto.Util;

namespace PedidoProduto.Entities
{
    public class Produto : Entity
    {
        public string nome { get; set; }

        public void Validar()
        {
            if (String.IsNullOrEmpty(this.nome))
                throw new ApplicationBadRequestException(ApplicationBadRequestException.NOME_INVALIDO);

            
        }
    }
    
}
