using System;
using System.Globalization;

namespace Utils.Date.Converters
{
    public class ConvertTypeStringToDateTime
    {
        public bool IsConverted{ get; protected set; }

        public string Message { get; protected set; }

        public DateTime? Value { get; protected set; }

        public ConvertTypeStringToDateTime(string date)
        {
            try
            {
                Value = DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture);
                IsConverted = true;
                Message = $"Converted {date} to {Value}";

                Console.WriteLine(Value > DateTime.Now);
            } catch(Exception ex)
            {
                Value = null;
                IsConverted = false;
                Message = ex.ToString();
            }
        }
    }
}
