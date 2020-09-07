using ColecaoLivrosAPI.Dominio.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColecaoLivrosAPI.Dominio.QueryExtensions
{
    public static class LivroQueryExtensions
    {

        public static IQueryable<Livro> GetByAutor(this IQueryable<Livro> livros, string autor)
        {
            throw new NotImplementedException();
        }
    }
}
