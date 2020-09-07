using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands
{
    public class GetLivroByIdCommand : IRequest<LivroResponseDto>
    {
        public long Id;
    }
}
