using Microsoft.EntityFrameworkCore;
using Vendas.Model;

namespace Vendas.Data
{
   
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Define as entidades do banco de dados como propriedades DbSet
        public DbSet<Cliente> ? Clientes { get; set; }

        public DbSet<Categoria>? Categorias { get; set; }

        public DbSet<Produto>? Produtos { get; set; }

    }
    }

