using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoBackend.Models;

namespace ProjetoBackend.Data
{
    /* Herança do Identity FrameWork */
    public class ApplicationDbContext : IdentityDbContext
    {
        // Construtor para injeção de dependência
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet para cada entidade do modelo
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ItemCompra> ItensCompra { get; set; }
        public DbSet<ServicoVenda> ServicoVenda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração de mapeamento de entidades
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Venda>().ToTable("Vendas");
            modelBuilder.Entity<Servico>().ToTable("Servicos");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedores");
            modelBuilder.Entity<Compra>().ToTable("Compras");
            modelBuilder.Entity<ItemCompra>().ToTable("ItensCompra");
            modelBuilder.Entity<ServicoVenda>().ToTable("ServicosVendas");
        }

    }
}
