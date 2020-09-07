
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace ColecaoLivrosAPI.Repositorio.Contexto
{
    public class ColecaoLivrosAPIContext : DbContext
    {
        

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public ColecaoLivrosAPIContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
