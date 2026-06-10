namespace IT_Asset_Management.Exceptions
{
    public class AlreadyTakenException : Exception
    {
        public AlreadyTakenException(string message) : base(message) { }
    }
}
