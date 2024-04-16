namespace ExceptionCurrency
{
    public class CurrencyException : Exception
    {
        public CurrencyException()
        { }

        public CurrencyException(string message) : base(message)
        { }
    }
}