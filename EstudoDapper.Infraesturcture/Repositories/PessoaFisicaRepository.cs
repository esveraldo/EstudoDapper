using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class PessoaFisicaRepository : BaseRepository<PessoaFisica, Guid>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
