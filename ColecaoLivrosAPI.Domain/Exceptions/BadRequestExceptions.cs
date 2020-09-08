using ColecaoLivrosAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ColecaoLivrosAPI.Domain.Exceptions
{
    public class BadRequestExceptions : Exception, IDomainException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public const string REGISTRO_FILHOS_ENCONTRADOS =
            "Não foi possível excluir, foi encontrado registros relacionados. Exclua os registros relacionados.";

        public BadRequestExceptions(string message) : base(message)
        {

        }
    }
}
