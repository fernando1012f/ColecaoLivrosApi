﻿// <auto-generated />
using ColecaoLivrosAPI.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace _34ew.Migrations
{
    [DbContext(typeof(ColecaoLivrosAPIContext))]
    [Migration("20200831192145_correcaoForeignKey")]
    partial class correcaoForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ColecaoLivrosAPI.Dominio.Models.Entidades.Autor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("ColecaoLivrosAPI.Dominio.Models.Entidades.Livro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AutorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<string>("NomeLivro")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("ColecaoLivrosAPI.Dominio.Models.Entidades.Livro", b =>
                {
                    b.HasOne("ColecaoLivrosAPI.Dominio.Models.Entidades.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
