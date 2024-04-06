namespace ExceptionCpf
{
    public class CpfException : Exception
    {
        public CpfException()
        { }

        public CpfException(string message) : base(message)
        { }
    }
}