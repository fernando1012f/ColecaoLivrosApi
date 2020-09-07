using ColecaoLivrosAPI.Application.Commands.Livro;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands.Autor
{
    public class PutAutorCommand : IRequest
    {
        public long AutorId { get; set; }
        public string NomeAutor { get; set; }
        public int Idade { get; set; }
        public IEnumerable<PutLivroCommand> LivrosEscritos { get; set; }
    }
}
