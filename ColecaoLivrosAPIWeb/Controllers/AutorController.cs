using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        public async Task<IActionResult> PostAutor([FromBody] PostAutorCommand postAutorCommand)
        {
            await mediator.Send(postAutorCommand);
            return Ok();
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutAutor(long Id, [FromBody]PutAutorCommand putAutorCommand)
        {
            await mediator.Send(new PutAutorCommand() {
               AutorId = Id,
               Idade = putAutorCommand.Idade,
               NomeAutor = putAutorCommand.NomeAutor,
               LivrosEscritos = putAutorCommand.LivrosEscritos});
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<AutorRequestDto>> GetAutores()
        {
            return Ok(await mediator.Send(new GetAutoresCommand()));
        }
        
        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<AutorRequestDto>> GetAutorById(long Id)
        {
            return Ok(await mediator.Send(new GetAutorByIdCommand() { AutorId = Id}));
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteAutor(long Id)
        {
            return Ok(await mediator.Send(new DeleteAutorCommand() { Id = Id }));
        }
    }
}
