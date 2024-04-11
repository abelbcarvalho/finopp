using CurrencyDTO;
using ICurrencies;

namespace Currencies
{
    public class FinanceCurrency : IFinanceCurrency
    {
        private readonly string apiUrl = "http://economia.awesomeapi.com.br/json/last";

        public DTOCurrency BitcoinToReal(decimal bitcoin)
        {
            string currency = this.JoinCurrenciesToUrl("BTC-BRL");

            throw new NotImplementedException();
        }

        public DTOCurrency DollarToReal(decimal dollar)
        {
            string currency = this.JoinCurrenciesToUrl("USD-BRL");

            throw new NotImplementedException();
        }

        public DTOCurrency EuroToReal(decimal euro)
        {
            string currency = this.JoinCurrenciesToUrl("EUR-BRL");

            throw new NotImplementedException();
        }

        public DTOCurrency RealToBitcoin(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-BTC");

            throw new NotImplementedException();
        }

        public DTOCurrency RealToDollar(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-USD");

            throw new NotImplementedException();
        }

        public DTOCurrency RealToEuro(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-EUR");

            throw new NotImplementedException();
        }

        protected string JoinCurrenciesToUrl(string currencies)
        {
            return $"{this.apiUrl}/{currencies}";
        }
    }
}