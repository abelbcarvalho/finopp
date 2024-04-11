using CurrencyDTO;
using ICurrencies;

namespace Currencies
{
    public class FinanceCurrency : IFinanceCurrency
    {
        private readonly string apiUrl = "http://economia.awesomeapi.com.br/json/last";

        public DTOCurrency BitcoinToReal(decimal bitcoin)
        {
            throw new NotImplementedException();
        }

        public DTOCurrency DollarToReal(decimal dollar)
        {
            throw new NotImplementedException();
        }

        public DTOCurrency EuroToReal(decimal euro)
        {
            throw new NotImplementedException();
        }

        public DTOCurrency RealToBitcoin(decimal real)
        {
            throw new NotImplementedException();
        }

        public DTOCurrency RealToDollar(decimal real)
        {
            throw new NotImplementedException();
        }

        public DTOCurrency RealToEuro(decimal real)
        {
            throw new NotImplementedException();
        }

        protected string JoinCurrenciesToUrl(string currencies)
        {
            return $"{this.apiUrl}/{currencies}";
        }
    }
}