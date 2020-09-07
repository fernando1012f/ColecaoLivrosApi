using ColecaoLivrosAPI.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands.Livro
{
    public class PutLivroCommand : IRequest
    {
        public long Id { get; set; }
        public string NomeLivro { get; set; }

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }

        public int AutorId { get; set; }
    }
}

