using ColecaoLivrosAPI.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public abstract class Entity
    {
        [NotMapped]       
        public List<IDomainEvent> Events = new List<IDomainEvent>();

        public void AddEvent(IDomainEvent domainEvent)
        {
            this.Events.Add(domainEvent);
        }

        public long Id { get; set; }
    }
}
