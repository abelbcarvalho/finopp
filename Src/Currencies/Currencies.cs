using CurrencyDTO;
using ICurrencies;

namespace Currencies
{
    public class FinanceCurrency : IFinanceCurrency
    {
        private readonly string apiUrl = "http://economia.awesomeapi.com.br/json/last";
        private readonly DTOCurrency currencyQuery = new();

        public DTOCurrency BitcoinToReal(decimal bitcoin)
        {
            string currency = this.JoinCurrenciesToUrl("BTC-BRL");

            this.currencyQuery.Description = "Bitcoin to Real";

            throw new NotImplementedException();
        }

        public DTOCurrency DollarToReal(decimal dollar)
        {
            string currency = this.JoinCurrenciesToUrl("USD-BRL");

            this.currencyQuery.Description = "Dollar to Real";

            throw new NotImplementedException();
        }

        public DTOCurrency EuroToReal(decimal euro)
        {
            string currency = this.JoinCurrenciesToUrl("EUR-BRL");

            this.currencyQuery.Description = "Euro to Real";

            throw new NotImplementedException();
        }

        public DTOCurrency RealToBitcoin(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-BTC");

            this.currencyQuery.Description = "Real to Bitcoin";

            throw new NotImplementedException();
        }

        public DTOCurrency RealToDollar(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-USD");

            this.currencyQuery.Description = "Real to Dollar";

            throw new NotImplementedException();
        }

        public DTOCurrency RealToEuro(decimal real)
        {
            string currency = this.JoinCurrenciesToUrl("BRL-EUR");

            this.currencyQuery.Description = "Real to Euro";

            throw new NotImplementedException();
        }

        protected string JoinCurrenciesToUrl(string currencies)
        {
            return $"{this.apiUrl}/{currencies}";
        }
    }
}