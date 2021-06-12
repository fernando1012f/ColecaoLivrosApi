using AutoMapper;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Autor;
using System;
using Utils.Date;
using Utils.Date.Converters;

namespace ColecaoLivrosAPIWeb.StartUp.MappingProfiles
{
    public class MappingAutor : BaseProfile
    {

        public MappingAutor()
        {
            CreateMap<Autor, AutorRequestDto>()
                .ForMember(dest => dest.LivrosEscritos, opt => opt.MapFrom(src => src.Livros));

            CreateMap<PostAutorCommand, Autor>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.LivrosEscritos))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataNascimentoConverted.Value))
                .ForMember(dest => dest.DataFalecimento, opt => opt.MapFrom(src => src.DataFalecimentoConverted.Value))
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<PutAutorCommand, Autor>()
                .ForMember(entidade => entidade.Id, comando => comando.MapFrom(src => src.AutorId))
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.LivrosEscritos));


            //CreateMap<AutorRequestDto, PostAutorCommand>()
            //    .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => DateUtils.ConvertStringToDateTime(src.DataNascimento)))
            //    .ForMember(dest => dest.DataFalecimento, opt => opt.MapFrom(src => DateUtils.ConvertStringToDateTime(src.DataFalecimento)));

        }
        
    }
}
