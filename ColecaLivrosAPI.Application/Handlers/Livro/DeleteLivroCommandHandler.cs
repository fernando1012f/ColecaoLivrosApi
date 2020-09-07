using ColecaoLivrosAPI.Application.Commands.Livro;
using ColecaoLivrosAPI.Domain.Exceptions;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Livro
{
    public class DeleteLivroCommandHandler : IRequestHandler<DeleteLivroCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Livro> _baseRepository;

        public async Task<Unit> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            var livro = _baseRepository.GetById(request.IdLivro)
                ?? throw new NotFoundExceptions(NotFoundExceptions.ID_NOT_FOUND);

            try
            {
                _baseRepository.Delete(livro);
            } catch(Exception ex)
            {
                throw new BadRequestExceptions(BadRequestExceptions.REGISTRO_FILHOS_ENCONTRADOS);
            }

            return Unit.Value;
        }

        public DeleteLivroCommandHandler(IBaseRepository<Dominio.Models.Entidades.Livro> baseRepository)
        {
            _baseRepository = baseRepository;
        }
    }
}
