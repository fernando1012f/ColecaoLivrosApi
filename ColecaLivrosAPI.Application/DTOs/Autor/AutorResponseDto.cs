using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.DTOs.Autor
{
    public class AutorResponseDto
    {
        public long Id { get; set; }
        public string NomeAutor { get; set; }
        public int Idade { get; set; }
        public IEnumerable<LivroResponseDto> LivrosEscritos {get; set;}
    }
}
