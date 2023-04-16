using EstudoDapper.Domain.Core;
using EstudoDapper.Infraesturcture.Data.Contexts;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        private readonly EntityFrameworkContext _entityFrameworkContext;

        public BaseRepository(EntityFrameworkContext entityFrameworkContext)
        {
            _entityFrameworkContext = entityFrameworkContext;
        }

        public List<TEntity> GetAll()
        {
            return _entityFrameworkContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(TKey id)
        {
            return _entityFrameworkContext.Set<TEntity>().Find(id);
        }

        public void Create(TEntity tentity)
        {
            _entityFrameworkContext.Add(tentity);
        }

        public void Delete(TEntity tentity)
        {
            _entityFrameworkContext.Remove(tentity);
        }

        public void Update(TEntity tentity)
        {
            _entityFrameworkContext.Update(tentity);
        }

        public void Dispose()
        {
            _entityFrameworkContext.Dispose();
        }
    }
}
