using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColecaoLivrosAPI.Application.Commands.Livro
{
    public class DeleteLivroCommand : IRequest
    {
        public long IdLivro { get; set; }
    }
}
