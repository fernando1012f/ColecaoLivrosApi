using AutoMapper;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Domain.Exceptions;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using ColecaoLivrosAPI.Repositorio.Repositorios;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Autor
{
    public class GetAutorByIdCommandHandler : IRequestHandler<GetAutorByIdCommand, AutorResponseDto>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Autor> _baseRepository;
        private readonly IMapper _mapper;

        public async Task<AutorResponseDto> Handle(GetAutorByIdCommand request, CancellationToken cancellationToken)
        {
            var autor = _baseRepository.GetById(request.AutorId)
                ?? throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);

            return _mapper.Map<Dominio.Models.Entidades.Autor, AutorResponseDto>(autor);
        }

        public GetAutorByIdCommandHandler(IBaseRepository<Dominio.Models.Entidades.Autor> baseRepository, IMapper mapper  )
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
