using AutoMapper;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Autor;

namespace ColecaoLivrosAPIWeb.StartUp.MappingProfiles
{
    public class MappingAutor : BaseProfile
    {
        public MappingAutor()
        {
            CreateMap<Autor, AutorResponseDto>()
                .ForMember(dest => dest.LivrosEscritos, opt => opt.MapFrom(src => src.Livros));

            CreateMap<PostAutorCommand, Autor>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.LivrosEscritos));

            CreateMap<PutAutorCommand, Autor>()
                .ForMember(entidade => entidade.Id, comando => comando.MapFrom(src => src.AutorId))
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.LivrosEscritos));

        }
    }
}
