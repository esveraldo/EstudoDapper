using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EntityFrameworkContext _entityFrameworkContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(EntityFrameworkContext entityFrameworkContext)
        {
            _entityFrameworkContext = entityFrameworkContext;
        }

        public IClienteRepository ClienteRepository => new ClienteRepository(_entityFrameworkContext);

        public IConjugeRepository ConjugeRepository => new ConjugeRepository(_entityFrameworkContext);

        public IImovelRepository IImovelRepository => new ImovelRepository(_entityFrameworkContext);

        public IPessoaFisicaRepository PessoaFisicaRepository => new PessoaFisicaRepository(_entityFrameworkContext);

        public IPessoaJuridicaRepository PessoaJuridicaRepository => new PessoaJuridicaRepository(_entityFrameworkContext);

        public void BeginTransaction()
        {
            _dbContextTransaction = _entityFrameworkContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction.Rollback();
        }

        public void Dispose()
        {
            _entityFrameworkContext.Dispose();
        }
    }
}
