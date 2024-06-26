using System.Text.Json;
using CurrencyDTO;
using ExceptionCurrency;
using ICurrencies;
using UtilStringToDec;

namespace Currencies
{
    public class FinanceCurrency : IFinanceCurrency
    {
        private readonly string apiUrl = "http://economia.awesomeapi.com.br/json/last";
        private readonly DTOCurrency currencyQuery = new();

        public async Task<DTOCurrency> BitcoinToReal()
        {
            string currency = this.JoinCurrenciesToUrl("BTC-BRL");

            this.currencyQuery.Description = "Bitcoin to Real";

            using var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(currency);

            this.BuildResponse(
                response,
                "BTCBRL",
                "error: problem to get the value of bitcoin in real"
            );

            return this.currencyQuery;
        }

        public async Task<DTOCurrency> DollarToReal()
        {
            string currency = this.JoinCurrenciesToUrl("USD-BRL");

            this.currencyQuery.Description = "Dollar to Real";

            using var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(currency);

            this.BuildResponse(
                response,
                "USDBRL",
                "error: problem to get the value of dollar in real"
            );

            return this.currencyQuery;
        }

        public async Task<DTOCurrency> EuroToReal()
        {
            string currency = this.JoinCurrenciesToUrl("EUR-BRL");

            this.currencyQuery.Description = "Euro to Real";

            using var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(currency);

            this.BuildResponse(
                response,
                "EURBRL",
                "error: problem to get the value of euro in real"
            );

            return this.currencyQuery;
        }

        public async Task<DTOCurrency> RealToDollar()
        {
            string currency = this.JoinCurrenciesToUrl("BRL-USD");

            this.currencyQuery.Description = "Real to Dollar";

            using var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(currency);

            this.BuildResponse(
                response,
                "BRLUSD",
                "error: problem to get the value of real in dollar"
            );

            return this.currencyQuery;
        }

        public async Task<DTOCurrency> RealToEuro()
        {
            string currency = this.JoinCurrenciesToUrl("BRL-EUR");

            this.currencyQuery.Description = "Real to Euro";

            using var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(currency);

            this.BuildResponse(
                response,
                "BRLEUR",
                "error: problem to get the value of real in euro"
            );

            return this.currencyQuery;
        }

        protected string JoinCurrenciesToUrl(string currencies)
        {
            return $"{this.apiUrl}/{currencies}";
        }

        protected async void BuildResponse(HttpResponseMessage? response, string currency, string exceptMsg)
        {
            if (response is not null && response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                Dictionary<string, Dictionary<string, object>> jsonCurrency = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(jsonResponse) ?? new();

                var value = jsonCurrency[currency]["bid"];

                this.currencyQuery.Value = StringToDecUtil.StringToDecimal(value.ToString());
            }
            else
            {
                throw new CurrencyException(exceptMsg);
            }
        }
    }
}