using ColecaoLivrosAPI.Application.Commands.Livro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands.Autor
{
    public abstract class AutorCommand
    {
        public long AutorId { get; set; }
        public string NomeAutor { get; set; }
        public string DataNascimento { get; set; }
        public string DataFalecimento { get; set; }
        //public DateTime DataNascimentoConverted { get; set; }
        //public DateTime? DataFalecimentoConverted { get; set; }
        public IEnumerable<PutLivroCommand> LivrosEscritos { get; set; }
        

    }
}
