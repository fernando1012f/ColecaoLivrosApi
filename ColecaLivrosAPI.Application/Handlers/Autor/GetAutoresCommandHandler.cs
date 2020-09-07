using AutoMapper;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColecaoLivrosAPI.Application.Handlers.Autor
{
    public class GetAutoresCommandHandler : IRequestHandler<GetAutoresCommand, IEnumerable<AutorResponseDto>>
    {
        private readonly IBaseRepository<Dominio.Models.Entidades.Autor> baseRepository;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<AutorResponseDto>> Handle(GetAutoresCommand request, CancellationToken cancellationToken)
        {
            var entity = baseRepository.Query().AsEnumerable().ToList();
            return _mapper.Map<List<Dominio.Models.Entidades.Autor>, List<AutorResponseDto>>(entity);
        }

        public GetAutoresCommandHandler(IBaseRepository<Dominio.Models.Entidades.Autor> baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
            this._mapper = mapper;
        }
    }
}
