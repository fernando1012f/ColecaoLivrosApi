using AutoMapper;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Dominio.Events;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Autor
{
    public class PostAutorCommandHandler : IRequestHandler<PostAutorCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Autor> _baseRepositoryAutor;
        private readonly IMapper _mapper;
       
        public async Task<Unit> Handle(PostAutorCommand request, CancellationToken cancellationToken)
        {
            
            var autorEntity = _mapper.Map<PostAutorCommand, Dominio.Models.Entidades.Autor>(request);
            
            autorEntity.AddEvent(new AutorCreatedEvent(autorEntity));
            _baseRepositoryAutor.Add(autorEntity);
            return Unit.Value;
        }

        public PostAutorCommandHandler(IBaseRepository<Dominio.Models.Entidades.Autor> baseRepositoryAutor, IMapper mapper)
        {
            _baseRepositoryAutor = baseRepositoryAutor;
            _mapper = mapper;
        }
    }
}
