using AutoMapper;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Application.DTOs.Autor;
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
    public class DeleteAutorCommandHandler : IRequestHandler<DeleteAutorCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Autor> _baseRepository;

        public async Task<Unit> Handle(DeleteAutorCommand request, CancellationToken cancellationToken)
        {
            var entity = _baseRepository.GetById(request.Id)
                ?? throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);

            try
            {
                _baseRepository.Delete(entity);
            }
            catch
            {
                throw new BadRequestExceptions(BadRequestExceptions.REGISTRO_FILHOS_ENCONTRADOS);
            }
            

            return Unit.Value;
        }

        public DeleteAutorCommandHandler(IBaseRepository<Dominio.Models.Entidades.Autor> baseRepository)
        {
            _baseRepository = baseRepository;
        }
    }
}
