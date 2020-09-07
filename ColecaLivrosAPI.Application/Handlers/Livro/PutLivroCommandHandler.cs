using AutoMapper;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Livro;
using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Domain.Exceptions;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Livro
{
    public class PutLivroCommandHandler : IRequestHandler<PutLivroCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Livro> _baseRepository;
        private readonly IMapper _mapper;
 
        public async Task<Unit> Handle(PutLivroCommand request, CancellationToken cancellationToken)
        {

            var entityToUpdate = _baseRepository.GetById(request.Id);

            if (entityToUpdate == null)
                throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);

            var newEntity = _mapper.Map<PutLivroCommand, Dominio.Models.Entidades.Livro>(request);

            _baseRepository.Detached(entityToUpdate);

            _baseRepository.Update(newEntity);

            return Unit.Value;

        }

        public PutLivroCommandHandler(IBaseRepository<Dominio.Models.Entidades.Livro> baseRepository , IMapper mapper )
        {
            this._baseRepository = baseRepository;
            this._mapper = mapper;
        }
    }
}
