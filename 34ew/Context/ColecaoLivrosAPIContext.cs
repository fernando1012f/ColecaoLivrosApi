
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

        public override int SaveChanges()
        {
            

            ChangeTracker.DetectChanges();

            var entidadeAlteradas =  ChangeTracker.Entries().Where(e => e.State == EntityState.Added || 
                                            e.State == EntityState.Modified || 
                                            e.State == EntityState.Deleted).ToList();


            var result = base.SaveChanges();


            foreach (var entidadeAlterada in entidadeAlteradas)
            {
                if(entidadeAlterada.Entity is Entity)
                {
                    var valor = entidadeAlterada.Entity as Entity;
                    
                    foreach (var evento in valor.Events)
                    {
                        //ToDo Publicar eventos
                    }

                    valor.Events.Clear();
                }
                
                
            }

            return result;
        }

    }
}
