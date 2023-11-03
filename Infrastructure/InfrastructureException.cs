using Common.Exceptions;

namespace Infrastructure;

public class InfrastructureException : BaseException
{
    public InfrastructureException(string? message) : base(message)
    {
    }
}

