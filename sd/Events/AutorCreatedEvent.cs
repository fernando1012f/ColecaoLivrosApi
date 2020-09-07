using ColecaoLivrosAPI.Domain.Events;
using ColecaoLivrosAPI.Dominio.Models.Entidades;


namespace ColecaoLivrosAPI.Dominio.Events
{
    public class AutorCreatedEvent : BaseEvent<Autor>
    {
        public AutorCreatedEvent(Autor autor) : base(autor)
        {
            
        }
    }
}
