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

        public const string ERRO_CONVERTER_DATA =
            "Erro ao converter data, o padrão para data é yyyyMMdd";
        
        public const string NOME_AUTOR_OBRIGATORIO = "O Nome do Autor é Obrigatório.";

        public const string TAMANHO_NOME_AUTOR_INVALIDO = "O Nome do Autor está invalido, deve conter entre 3 e 300 caracteres.";

        public const string ID_NULO = "Não foi informado ID";

        public const string DATA_NASCIMENTO_OBRIGATORIO = "A Data de Nascimento não informada.";

        public const string DATA_NASCIMENTO_MAIOR_DATA_FALECIMENTO = "A Data de Nascimento é maior que Data Falecimento.";

        public const string DATA_NASCIMENTO_INVALIDA = "Data de Nascimento Inválida";

        public const string DATA_FALECIMENTO_INVALIDA = "Data de Falecimento Inválida";


        public BadRequestExceptions(string message) : base(message)
        {

        }
    }
}
