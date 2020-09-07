using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Dominio.Models.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        void AddRange(List<TEntity> entities);

        TEntity GetById(long id);

        IQueryable<TEntity> Query();

        void Update(TEntity entity);
            
        void Delete(TEntity entity);

        void Detached(TEntity entity);
    }
}
