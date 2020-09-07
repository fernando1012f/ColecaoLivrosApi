using AutoMapper;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ColecaoLivrosAPI.Domain.Exceptions;

namespace ColecaoLivrosAPI.Application.Handlers
{
    class GetLivroByIdCommandHandler : IRequestHandler<GetLivroByIdCommand, LivroResponseDto>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Livro> baseRepositorio;
        private readonly IMapper _mapper;

        public async Task<LivroResponseDto> Handle(GetLivroByIdCommand request, CancellationToken cancellationToken)
        {
            var livro = baseRepositorio.GetById(request.Id);

            if (livro == null)
                throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);

            return _mapper.Map<Dominio.Models.Entidades.Livro, LivroResponseDto>(livro);
        }

        public GetLivroByIdCommandHandler(IBaseRepository<Dominio.Models.Entidades.Livro> baseRepositorio, IMapper mapper)
        {
            this.baseRepositorio = baseRepositorio;
            this._mapper = mapper;
        }
    }
}
