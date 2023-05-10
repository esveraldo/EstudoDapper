using EstudoDapper.Domain.Core;
using EstudoDapper.Infraesturcture.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using static Dapper.SqlMapper;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        private readonly EntityFrameworkContext _entityFrameworkContext;

        public BaseRepository(EntityFrameworkContext entityFrameworkContext)
        {
            _entityFrameworkContext = entityFrameworkContext;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return _entityFrameworkContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> GetById(TKey id)
        {
            _entityFrameworkContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return _entityFrameworkContext.Set<TEntity>().Find(id);
        }

        public async Task Create(TEntity tentity)
        {
             _entityFrameworkContext.Add(tentity);
        }

        public async Task Delete(TEntity tentity)
        {
            _entityFrameworkContext.Remove(tentity);
        }

        public async Task Update(TEntity tentity)
        {
            _entityFrameworkContext.Update(tentity);
        }

        public int SaveChanges()
        {
            return _entityFrameworkContext.SaveChanges();
        }

        public void Dispose()
        {
            _entityFrameworkContext.Dispose();
        }
    }
}
