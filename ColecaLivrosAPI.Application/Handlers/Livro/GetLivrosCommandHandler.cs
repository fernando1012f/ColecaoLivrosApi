using AutoMapper;
using ColecaLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Dominio.QueryExtensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaLivrosAPI.Application.Handlers
{
    public class GetLivrosCommandHandler : IRequestHandler<GetLivrosCommand, IEnumerable<LivroResponseDto>>
    {
        private readonly IBaseRepository<Livro> baseRepositorio;
        private readonly IMapper _mapper;
        public async Task<IEnumerable<LivroResponseDto>> Handle(GetLivrosCommand request, CancellationToken cancellationToken)
        {
            var entity = baseRepositorio.Query().AsEnumerable().ToList();
            return _mapper.Map<List<Livro>, List<LivroResponseDto>>(entity);
            
            //return baseRepositorio.Query().Select(x => new ResponseLivroDto() {NomeLivro = x.NomeLivro });
        }

        
        public GetLivrosCommandHandler(IBaseRepository<Livro> baseRepositorio, IMapper mapper )
        {
            
            this.baseRepositorio = baseRepositorio;
            this._mapper = mapper;
        }
    }
}
