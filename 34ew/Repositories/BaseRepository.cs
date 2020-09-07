using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using ColecaoLivrosAPI.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace ColecaoLivrosAPI.Repositorio.Repositorios
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ColecaoLivrosAPIContext _contexto;
        public BaseRepository(ColecaoLivrosAPIContext ctx)
        {
            _contexto = ctx;
        }

        public TEntity Add(TEntity entity)
        {
            var entidadeCriada = _contexto.Add(entity);
            _contexto.SaveChanges();

            return entidadeCriada.Entity;
        }

        public void AddRange(List<TEntity> entities)
        {
            _contexto.AddRange(entities);
            _contexto.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _contexto.Remove(entity);
            _contexto.SaveChanges();
        }

        public TEntity GetById(long id)
        {
            return _contexto.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Query()
        {
            return _contexto.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            _contexto.Update(entity);
            _contexto.SaveChanges();
        }
        public void Detached(TEntity entity)
        {
            _contexto.Entry(entity).State = EntityState.Detached;
        }
    }
}
