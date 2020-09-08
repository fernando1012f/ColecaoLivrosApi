
using ColecaoLivrosAPI.Dominio.Events;
using ColecaoLivrosAPI.Dominio.Interfaces;
using System;
using System.Collections.Generic;

namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public class Autor : Entity
    {
        public string NomeAutor { get; set; }
        
        public int Idade { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}

