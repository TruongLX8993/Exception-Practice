namespace Common.Exceptions;

public class BaseException : Exception
{
    public int Code { get; set; }
    public string PlainMessage { get; set; }
    public string Description { get; set; }

    
    public BaseException()
    {
    }

    public BaseException(string? message) : base(message)
    {
    }

    public BaseException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}