
using Vendas.Data;
using Vendas.Model;
using Vendas.Repositories.Interfaces;

namespace Vendas.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDataContext _context;
        public ClienteRepository(AppDataContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Cliente> Produtos => throw new NotImplementedException();

        public Cliente GetClienteById(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
