using AutoMapper;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Domain.Exceptions;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Autor
{
    public class PutAutorCommandHandler : IRequestHandler<PutAutorCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Autor> _baseRepository;
        private readonly IMapper _mapper;

        public async Task<Unit> Handle(PutAutorCommand request, CancellationToken cancellationToken)
        {
            var findAutor = _baseRepository.GetById(request.AutorId);
             
            if(findAutor == null)
            {
                throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);
            }

            var entity = _mapper.Map<PutAutorCommand, Dominio.Models.Entidades.Autor>(request);

            _baseRepository.Detached(findAutor);
            _baseRepository.Update(entity);

            return Unit.Value;
        }

        public PutAutorCommandHandler(IBaseRepository<Dominio.Models.Entidades.Autor> baseRepository, IMapper mapper )
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
