using CurrencyDTO;

namespace ICurrencies
{
    public interface IFinanceCurrency
    {
        abstract Task<DTOCurrency> DollarToReal();
        abstract Task<DTOCurrency> RealToDollar();
        abstract Task<DTOCurrency> EuroToReal();
        abstract Task<DTOCurrency> RealToEuro();
        abstract Task<DTOCurrency> BitcoinToReal();
        abstract Task<DTOCurrency> RealToBitcoin();
    }
}