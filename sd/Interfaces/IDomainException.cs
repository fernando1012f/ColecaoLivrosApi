using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ColecaoLivrosAPI.Domain.Interfaces
{
    public interface IDomainException
    {
        public HttpStatusCode StatusCode { get; }

    }
}
