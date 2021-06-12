
using ColecaoLivrosAPI.Dominio.Events;
using ColecaoLivrosAPI.Dominio.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public class Autor : Entity
    {
        public string NomeAutor { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataNascimento { get; set; }

        public DateTime? DataFalecimento { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}

