﻿namespace EstudoDapper.Domain.Core
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        void Create(TEntity tentity);
        void Update(TEntity tentity);
        void Delete(TEntity tentity);

        List<TEntity> GetAll();
        TEntity GetById(TKey id);
    }
}
