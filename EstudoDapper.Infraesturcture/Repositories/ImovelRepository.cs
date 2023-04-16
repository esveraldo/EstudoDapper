using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class ImovelRepository : BaseRepository<Imovel, Guid>, IImovelRepository
    {
        public ImovelRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
