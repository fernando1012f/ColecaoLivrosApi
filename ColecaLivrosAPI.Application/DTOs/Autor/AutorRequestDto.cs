using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.DTOs.Autor
{
    public class AutorRequestDto
    {
        public long Id { get; set; }
        public string NomeAutor { get; set; }
        public string DataNascimento { get; set; }
        public string DataFalecimento { get; set; }
        public IEnumerable<AutorLivroRequestDto> LivrosEscritos {get; set;}
    }
}
