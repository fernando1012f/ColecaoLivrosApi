using ColecaoLivrosAPIWeb.StartUp.Validations.Autor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using Utils.Date.Converters;

namespace ColecaoLivrosAPI.Application.Commands.Autor.Validations
{
    public class PostAutorCommandValidation : AutorCommandValidation<PostAutorCommand>
    {
        public PostAutorCommandValidation(ConvertFormatYearMonthDay convertStringToDateTime) : base(convertStringToDateTime)
        {
            _convertStringToDateTime = convertStringToDateTime;
            ValidateNomeAutor();
            ValidateDataNascimento();
            ValidateDataFalecimento();

        }

    }
}
