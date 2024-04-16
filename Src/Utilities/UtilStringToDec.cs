using System.Globalization;

namespace UtilStringToDec
{
    public class StringToDecUtil
    {
        public static decimal StringToDecimal(string? decValue)
        {
            if (decValue is null)
            {
                throw new Exception("error: please don't send null value here");
            }

            CultureInfo usa = new("en-US");

            Decimal.TryParse(decValue, usa, out decimal valueDecimal);

            return valueDecimal;
        }
    }
}