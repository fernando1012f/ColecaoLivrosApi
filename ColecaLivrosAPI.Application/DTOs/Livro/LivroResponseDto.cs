using ColecaoLivrosAPI.Application.DTOs.Autor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.DTOs
{
    public class LivroResponseDto
    {
        public long Id { get; set; }
        public string NomeLivro { get; set; }

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }

        public long AutorId { get; set; }
        

    }
}
