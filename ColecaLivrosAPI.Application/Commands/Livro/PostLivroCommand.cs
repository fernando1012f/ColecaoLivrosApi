using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands
{
    public class PostLivroCommand : IRequest
    {
        public string NomeLivro { get; set; }

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }

        public long AutorId { get; set; }
    }
}
