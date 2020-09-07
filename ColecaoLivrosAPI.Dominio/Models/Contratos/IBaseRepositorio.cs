using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Dominio.Models.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        IQueryable<TEntity> Query();

        void Update(TEntity entity);
            
        void Delete(TEntity entity);
    }
}
