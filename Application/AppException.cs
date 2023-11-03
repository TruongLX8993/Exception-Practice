using Common.Exceptions;

namespace Application;

public class AppException : BaseException
{
    public int Code { get; set; }

    
    
    public AppException()
    {
    }

    public AppException WithCode(int code)
    {
        Code = code;
        return this;
    }

    public AppException(string? message) : base(message)
    {
    }

    public AppException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}