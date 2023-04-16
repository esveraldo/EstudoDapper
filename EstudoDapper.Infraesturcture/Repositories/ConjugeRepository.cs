using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class ConjugeRepository : BaseRepository<Conjuge, Guid>, IConjugeRepository
    {
        public ConjugeRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
