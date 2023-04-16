using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Queries.Clientes;

namespace EstudoDapper.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteQuery Add(CriarClienteCommand command);
    }
}
