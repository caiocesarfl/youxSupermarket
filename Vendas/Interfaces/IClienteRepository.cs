
using Vendas.Model;

namespace Vendas.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Cliente { get; }

        Cliente GetClienteById(int clienteId);

    }
}
