using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Application.DTOs.Autor;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ColecaoLivrosAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IMediator mediator;

        public AutorController(IMediator mediator)
        {
            this.mediator = mediator;
        } 
        [HttpPost]
        public async Task<Unit> PostAutor(PostAutorCommand postAutorCommand)
        {
            return await mediator.Send(postAutorCommand);
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<Unit> PutAutor(long Id, [FromBody]PutAutorCommand putAutorCommand)
        {
            return await mediator.Send(new PutAutorCommand() {
               AutorId = Id,
               Idade = putAutorCommand.Idade,
               NomeAutor = putAutorCommand.NomeAutor,
               LivrosEscritos = putAutorCommand.LivrosEscritos});
        }

        [HttpGet]
        public async Task<IEnumerable<AutorResponseDto>> GetAutores()
        {
            return await mediator.Send(new GetAutoresCommand());
        }
        
        [HttpGet]
        [Route("{Id}")]
        public async Task<AutorResponseDto> GetAutorById(long Id)
        {
            return await mediator.Send(new GetAutorByIdCommand() { AutorId = Id});
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<Unit> DeleteAutor(long Id)
        {
            return await mediator.Send(new DeleteAutorCommand() { Id = Id });
        }
    }
}
