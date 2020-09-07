using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Dominio.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands
{
    public class PostAutorCommand : IRequest
    {
        public string NomeAutor { get; set; }

        public int Idade { get; set; }

        public IEnumerable<AutorLivroRequestDto> LivrosEscritos { get; set; }
    }

}
