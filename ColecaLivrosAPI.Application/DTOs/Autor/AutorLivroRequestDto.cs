using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.DTOs.Autor
{
    public class AutorLivroRequestDto
    {
        public string NomeLivro { get; set; }

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }
    }
}
