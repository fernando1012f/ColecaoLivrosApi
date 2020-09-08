using ColecaoLivrosAPI.Dominio.Interfaces;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Domain.Events
{
    public class BaseEvent<TEntity> : IDomainEvent where TEntity : Entity
    {
        private readonly TEntity entity;

        public BaseEvent(TEntity entity)
        {
            this.entity = entity;
        }

        public long Id { 
            get { return entity.Id; } 
            set { id = value; } }

        private long id;
    }
}
