using ColecaoLivrosAPI.Application.DTOs.Autor;
using MediatR;


namespace ColecaoLivrosAPI.Application.Commands.Autor
{
    public class DeleteAutorCommand : IRequest
    {
        public long Id { get; set; }
    }
}
