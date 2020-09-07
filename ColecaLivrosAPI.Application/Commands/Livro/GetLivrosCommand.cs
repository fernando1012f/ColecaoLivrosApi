using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColecaLivrosAPI.Application.Commands
{
    public class GetLivrosCommand : IRequest <IEnumerable<LivroResponseDto>>
    {
        

    }
}
