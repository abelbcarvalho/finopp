using CurrencyDTO;

namespace ICurrencies
{
    public interface IFinanceCurrency
    {
        abstract DTOCurrency DollarToReal(decimal dollar);
        abstract DTOCurrency RealToDollar(decimal real);
        abstract DTOCurrency EuroToReal(decimal euro);
        abstract DTOCurrency RealToEuro(decimal real);
        abstract DTOCurrency BitcoinToReal(decimal bitcoin);
        abstract DTOCurrency RealToBitcoin(decimal real);
    }
}