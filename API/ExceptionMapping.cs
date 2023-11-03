using Application;
using Common;

namespace API;

public class ExceptionMapping
{
    public IEnumerable<Error> Map(Exception e)
    {
        if (e is AppException appException)
            return new[] { new Error(appException.Code, appException.Message) };
        return new[] { new Error(500, e.Message) };
    }
}