namespace ColecaoLivrosAPI.Dominio.Models.Entidades
{
    public class Livro : Entidade
    {
        public int Id { get; set; }

        public string NomeLivro {get; set;}

        public string Editora { get; set; }

        public int NumeroPaginas { get; set; }

        public int AutorId { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
