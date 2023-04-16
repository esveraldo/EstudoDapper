using EstudoDapper.Domain.Core;
using EstudoDapper.Domain.Entities;

namespace EstudoDapper.Domain.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente, Guid>
    {
    }
}
