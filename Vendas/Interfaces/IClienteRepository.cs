
using Vendas.Model;

namespace Vendas.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Produtos { get; }
        Cliente GetClienteById(int clienteId);

    }
}
