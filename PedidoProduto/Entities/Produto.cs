using System.ComponentModel.DataAnnotations.Schema;

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
