using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColecaLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Livro;
using ColecaoLivrosAPI.Application.DTOs;
using ColecaoLivrosAPI.Dominio.Models.Entidades;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ColecaoLivrosAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly IMediator mediatr;

        public LivroController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }

        [HttpGet]
        public async Task<ActionResult<LivroResponseDto>> GetLivros()
        {
           return Ok(await mediatr.Send(new GetLivrosCommand()));
        }

        [Route("{Id}")]
        public async Task<ActionResult<LivroResponseDto>> GetLivroById(int Id)
        {
            return Ok(await mediatr.Send(new GetLivroByIdCommand() { Id = Id}));
        }

        [HttpPost]
        public async Task<IActionResult> PostLivro(PostLivroCommand postLivroCommand)
        {
            return Ok(await mediatr.Send(postLivroCommand));
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutLivro(long Id, [FromBody] PutLivroCommand putLivroCommand)
        {
            await mediatr.Send(new PutLivroCommand()
            {
                Id = Id,
                NomeLivro = putLivroCommand.NomeLivro,
                Editora = putLivroCommand.Editora,
                NumeroPaginas = putLivroCommand.NumeroPaginas,
                AutorId = putLivroCommand.AutorId
            });

            return Ok();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteLivroById(long Id)
        {
            return Ok(await mediatr.Send(new DeleteLivroCommand() { IdLivro = Id }));
        }
    }
}
