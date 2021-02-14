using Microsoft.EntityFrameworkCore;
using PedidoProduto.Entities;
using System.Linq;

namespace PedidoProduto.Persistencia
{
    public class Repositorio : DbContext
    {

        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
      
        public DbSet<ClientePedido> ClientePedidos { get; set; }
        public DbSet<PedidoProduto> PedidoProdutos { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties()).ToList()
                .ForEach(c => c.Relational().ColumnName = ToSnakeCase(c.Name));

            modelBuilder.Entity<Cliente>().ToTable("CLIENTE");
            modelBuilder.Entity<Produto>().ToTable("PRODUTO");
            modelBuilder.Entity<Pedido>().ToTable("PEDIDOS");

            modelBuilder.Entity<ClientePedido>().ToTable("CLIENTEPEDIDO");
            modelBuilder.Entity<PedidoProduto>().ToTable("PEDIDOPRODUTO");
         
        }

        private string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
