using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
    {
        public ClienteRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
