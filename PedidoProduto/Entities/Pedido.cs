using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoProduto.Entities
{
    public class Pedido : Entity
    {
        public DateTime dataPedido {get ; set; }
        public double total { get; set; }

        public virtual List<Produto> produtos { get; set; }

        public void Validar()
        {
            if (String.IsNullOrEmpty(this.dataPedido))
                throw new ApplicationBadRequestException(ApplicationBadRequestException.DATA_INVALIDA);

            if (String.IsNullOrEmpty(this.total) || this.total < 0)
                throw new ApplicationBadRequestException(ApplicationBadRequestException.TOTAL_INVALIDO);

            if (this.produtos != null && this.produtos.Count > 0)
            {
                List<Produto> lista = new List<Pedido>();
                foreach (var item in this.produtos)
                {
                    Produto produto = lista.Where(x => x.id == item.id).FirstOrDefault();
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
