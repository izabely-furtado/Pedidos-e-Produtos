using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoProduto.Entities
{
    public class PedidoProdutoE : Entity
    {
        [ForeignKey("PRODUTO")]
        public int produtoID { get; set; }
        public virtual Produto Produto { get; set; }

        [ForeignKey("PEDIDO")]
        public int pedidoID { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
