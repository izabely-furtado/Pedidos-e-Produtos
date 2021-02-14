using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoProduto.Entities
{
    public class PedidoProduto : Entity
    {
        [ForeignKey("PRODUTO")]
        public int produto { get; set; }
        public virtual Produto Produto { get; set; }

        [ForeignKey("PEDIDO")]
        public int pedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
