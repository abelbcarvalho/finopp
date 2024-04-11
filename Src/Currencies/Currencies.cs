namespace Currencies
{
    public class FinanceCurrency
    {
        private readonly string apiUrl = "http://economia.awesomeapi.com.br/json/last";

        protected string JoinCurrenciesToUrl(string currencies)
        {
            return $"{this.apiUrl}/{currencies}";
        }
    }
}