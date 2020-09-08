
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColecaoLivrosAPI.Repositorio.Config
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(l => l.Id);

            builder
                .Property(l => l.NomeLivro)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(l => l.Editora)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(l => l.NumeroPaginas)
                .IsRequired();
        }
    }
}
