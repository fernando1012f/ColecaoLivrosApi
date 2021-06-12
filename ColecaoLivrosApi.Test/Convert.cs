using System;
using Utils.Date.Converters;
using Xunit;

namespace ColecaoLivrosApi.Test
{
    public class Convert
    {
        [Fact]
        public void ConvertTest()
        {
            var dateString = "19930302";

            var convertMethod = new ConvertFormatYearMonthDay();

            var result = convertMethod.Convert(dateString);

            Assert.True(result.IsConverted);

        }
    }
}
