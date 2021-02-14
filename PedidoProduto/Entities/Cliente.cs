using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoProduto.Entities
{
    public class Cliente : Entity
    {
        public string nome { get; set; }

        public virtual List<Pedido> pedidos { get; set; }

        public void Validar()
        {
            if (String.IsNullOrEmpty(this.nome))
                throw new ApplicationBadRequestException(ApplicationBadRequestException.NOME_INVALIDO);

            if (this.pedidos != null && this.pedidos.Count > 0)
            {
                List<Pedido> lista = new List<Pedido>();
                foreach (var item in this.pedidos)
                {
                    Pedido pedido = lista.Where(x => x.id == item.id).FirstOrDefault();
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
