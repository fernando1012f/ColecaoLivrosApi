using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPI.Domain.Exceptions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Date.Converters;

namespace ColecaoLivrosAPIWeb.StartUp.Validations.Autor
{
    public class AutorCommandValidation<T> : AbstractValidator <T> where T : AutorCommand
    {
        private protected ConvertFormatYearMonthDay _convertStringToDateTime;

        public AutorCommandValidation(ConvertFormatYearMonthDay convertStringToDateTime)
        {
            _convertStringToDateTime = convertStringToDateTime;
        }

        protected void ValidateAutorId()
        {
            RuleFor(a => a.AutorId)
                .NotNull().NotEmpty().WithMessage(BadRequestExceptions.ID_NULO)

                .WithMessage(BadRequestExceptions.ID_NULO);

        }
        protected void ValidateNomeAutor()
        {
            RuleFor(a => a.NomeAutor)
                .NotNull().NotEmpty().WithMessage(BadRequestExceptions.NOME_AUTOR_OBRIGATORIO)
                .WithMessage(BadRequestExceptions.NOME_AUTOR_OBRIGATORIO)
                .Length(3, 300).WithMessage(BadRequestExceptions.TAMANHO_NOME_AUTOR_INVALIDO);
        }

        protected void ValidateDataNascimento()
        {

            RuleFor(a => a.DataNascimento)
                .NotNull().NotEmpty()
                .WithMessage(BadRequestExceptions.DATA_NASCIMENTO_OBRIGATORIO);
            RuleFor(a => a.DataNascimento)
                .Must(dn => _convertStringToDateTime.Convert(dn).IsConverted)
                .WithMessage(BadRequestExceptions.ERRO_CONVERTER_DATA);
            RuleFor(a => a.DataNascimento)
                .Must(dn => _convertStringToDateTime.Convert(dn).Value <= DateTime.Now)
                .WithMessage(BadRequestExceptions.DATA_NASCIMENTO_INVALIDA);
            RuleFor(a => ConvertStringToDateObject(a.DataNascimento).Value)
                .LessThanOrEqualTo(a => ConvertStringToDateObject(a.DataFalecimento).Value)
                .When(a => ConvertStringToDateObject(a.DataFalecimento).IsConverted)
                .WithMessage(BadRequestExceptions.DATA_NASCIMENTO_MAIOR_DATA_FALECIMENTO);
   
        }

        protected void ValidateDataFalecimento()
        {
            

            RuleFor(autor => autor.DataFalecimento)
                .Must(df => ConvertStringToDateObject(df).IsConverted)
                .When(a => !string.IsNullOrEmpty(a.DataFalecimento))
                .WithMessage(BadRequestExceptions.ERRO_CONVERTER_DATA);
            
                
            RuleFor(autor => autor.DataFalecimento)
                .Must(df => ConvertStringToDateObject(df).Value <= DateTime.Now)
                .When(a => ConvertStringToDateObject(a.DataFalecimento).IsConverted)
                .WithMessage(BadRequestExceptions.DATA_FALECIMENTO_INVALIDA);
           
        }

        private ConvertTypeStringToDateTime ConvertStringToDateObject(string date)
        {
            return _convertStringToDateTime.Convert(date);
        }
    }
}
