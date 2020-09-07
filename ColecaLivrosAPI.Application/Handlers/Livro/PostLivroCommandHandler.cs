using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Livro
{
    class PostLivroCommandHandler : IRequestHandler<PostLivroCommand>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Livro> baseRepositorio;

        public async Task<Unit> Handle(PostLivroCommand request, CancellationToken cancellationToken)
        {
            baseRepositorio.Add(new Dominio.Models.Entidades.Livro(){NomeLivro = request.NomeLivro, 
                                                                     NumeroPaginas = request.NumeroPaginas,
                                                                     Editora = request.Editora,
                                                                     AutorId = request.AutorId});
            return Unit.Value;
        }

        public PostLivroCommandHandler(IBaseRepository<Dominio.Models.Entidades.Livro> baseRepositorio)
        {
            this.baseRepositorio = baseRepositorio;
        }
    }
}
