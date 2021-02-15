using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoProduto.Entities
{
    public class ClientePedido : Entity
    {
        [ForeignKey("CLIENTE")]
        public int cliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("PEDIDO")]
        public int pedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
