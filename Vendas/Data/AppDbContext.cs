using Microsoft.EntityFrameworkCore;
using Vendas.Model;

namespace Vendas.Data
{
    public class AppDataContext : DbContext
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            // Define as entidades do banco de dados como propriedades DbSet
            public DbSet<Cliente> Cliente { get; set; }
        }
    }
}
