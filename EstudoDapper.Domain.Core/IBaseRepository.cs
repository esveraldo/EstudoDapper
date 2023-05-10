namespace EstudoDapper.Domain.Core
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task Create(TEntity tentity);
        Task Update(TEntity tentity);
        Task Delete(TEntity tentity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
        int SaveChanges();
    }
}
