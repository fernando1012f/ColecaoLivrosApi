
using System.Collections.Generic;

namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public class Autor : Entidade
    {
        public int Id { get; set; }
        public string NomeAutor { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
