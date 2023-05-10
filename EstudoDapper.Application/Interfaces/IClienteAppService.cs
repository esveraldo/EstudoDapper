using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Queries.Clientes;

namespace EstudoDapper.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        Task<List<ClienteQuery>> GetAll();
        Task<ClienteQuery> GetById(Guid id);
        Task<ClienteQuery> Add(CriarClienteCommand command);
        Task<ClienteQuery> Update(AtualizarClienteCommand command);
        Task<ClienteQuery> Remove(Guid id);
    }
}
