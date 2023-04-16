using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class PessoaJuridicaRepository : BaseRepository<PessoaJuridica, Guid>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
