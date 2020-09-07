
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColecaoLivrosAPI.Repositorio.Config
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.NomeAutor)
                .IsRequired()
                .HasMaxLength(300);

            builder
                .HasMany(a => a.Livros)
                .WithOne(l => l.Autor);

        }
    }
}

