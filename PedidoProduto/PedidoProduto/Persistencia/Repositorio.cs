using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PedidoProduto.Entities;
using System.Data;
using System.Linq;

namespace PedidoProduto.Persistencia
{
    public class Repositorio : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=VMI368814;Initial Catalog=PedidoProduto;Integrated Security=True");
            }
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
      
        public DbSet<ClientePedido> ClientePedidos { get; set; }
        public DbSet<PedidoProdutoE> PedidoProdutos { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("CLIENTE");
            modelBuilder.Entity<Produto>().ToTable("PRODUTO");
            modelBuilder.Entity<Pedido>().ToTable("PEDIDOS");

            modelBuilder.Entity<ClientePedido>().ToTable("CLIENTEPEDIDO");
            modelBuilder.Entity<PedidoProdutoE>().ToTable("PEDIDOPRODUTO");
         
        }

        private string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
