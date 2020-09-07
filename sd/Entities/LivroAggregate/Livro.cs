namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public class Livro : Entity
    {
        public string NomeLivro {get; set;}

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }

        public long AutorId { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
