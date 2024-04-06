namespace ExceptionDatabase
{
    public class DatabaseException : Exception
    {
        public DatabaseException()
        { }

        public DatabaseException(string message) : base(message)
        { }
    }
}