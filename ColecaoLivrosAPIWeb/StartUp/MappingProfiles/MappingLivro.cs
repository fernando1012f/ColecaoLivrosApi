using AutoMapper;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Livro;
using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPIWeb.StartUp.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.MappingProfiles
{
    public class MappingLivro : BaseProfile
    {
        public MappingLivro()
        {
            CreateMap<Livro, LivroResponseDto>();

            CreateMap<PutLivroCommand, Livro>();

            CreateMap<AutorLivroRequestDto, Livro>();

        }
    }
}
