using System;
using System.Globalization;
using Utils.Date.Contracts;

namespace Utils.Date.Converters
{

    public class ConvertFormatYearMonthDay : IConvert<ConvertTypeStringToDateTime>
    {
        public ConvertTypeStringToDateTime Convert(string date)
        {
            return new ConvertTypeStringToDateTime(date);
        }
    }
}
