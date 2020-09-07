using ColecaoLivrosAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ColecaoLivrosAPI.Domain.Exceptions
{
    public class NotFoundExceptions : Exception, IDomainException
    {
        HttpStatusCode IDomainException.StatusCode => HttpStatusCode.NotFound;
        
        public const string ID_NOT_FOUND = "Não foi encontrado nenhum resultado com esse ID";

        public NotFoundExceptions(string message) : base(message)
        {

        }
    }

}
