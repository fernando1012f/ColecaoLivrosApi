using ColecaoLivrosAPI.Application.Commands.Autor;
using MediatR;
using System;
using Utils.Date.Converters;

namespace ColecaoLivrosAPI.Application.Commands
{
    public class PostAutorCommand : AutorCommand, IRequest
    {
        public ConvertTypeStringToDateTime DataNascimentoConverted { get; private set; }
        public ConvertTypeStringToDateTime DataFalecimentoConverted { get; private set; }

        private readonly ConvertFormatYearMonthDay _convertStringToDateTime;

        public PostAutorCommand(ConvertFormatYearMonthDay convertStringToDateTime)
        {
            _convertStringToDateTime = convertStringToDateTime;
            DataNascimentoConverted = _convertStringToDateTime.Convert(DataNascimento);
            DataFalecimentoConverted = _convertStringToDateTime.Convert(DataFalecimento);
        }
       
    }
    
}
