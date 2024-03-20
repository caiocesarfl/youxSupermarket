
using Vendas.Data;
using Vendas.Model;
using Vendas.Repositories.Interfaces;

namespace Vendas.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Cliente> Cliente => throw new NotImplementedException();

        public Cliente GetClienteById(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
