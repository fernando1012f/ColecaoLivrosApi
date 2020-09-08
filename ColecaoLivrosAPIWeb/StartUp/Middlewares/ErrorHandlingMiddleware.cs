using ColecaoLivrosAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoLivrosAPIWeb.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected
            var message = "Erro interno";
            if (exception is IDomainException)
            {
                var domainException = exception as IDomainException;
                code = domainException.StatusCode;
                message = exception.Message;
            }
                
             // else if (exception is MyUnauthorizedException) code = HttpStatusCode.Unauthorized;
             // else if (exception is MyException)             code = HttpStatusCode.BadRequest;

             var result = JsonConvert.SerializeObject(new { error = message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
