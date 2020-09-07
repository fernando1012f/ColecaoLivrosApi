using ColecaoLivrosAPI.Application.DTOs.Autor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands.Autor
{
    public class GetAutorByIdCommand : IRequest<AutorResponseDto>
    {
        public long AutorId { get; set; }
    }
}
