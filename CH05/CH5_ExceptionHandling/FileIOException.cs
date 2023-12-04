namespace CH5_ExceptionHandling;

public class FileIOException : Exception
{
    public FileIOException(string message) : base(message)
    {
    }
}