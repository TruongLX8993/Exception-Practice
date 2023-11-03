namespace API.Middleware;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ExceptionMapping _exceptionMapping;
    private readonly ILogger<GlobalExceptionMiddleware> _logger;

    public GlobalExceptionMiddleware(RequestDelegate next, ExceptionMapping exceptionMapping, ILogger<GlobalExceptionMiddleware> logger)
    {
        _next = next;
        _exceptionMapping = exceptionMapping;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            _logger.LogError(e.InnerException, "TraceId: {traceId},Url: {url},Msg: {msg}", context.TraceIdentifier, context.Request.Path, e.Message);
            var rs = new ApiResponse
            {
                TraceId = context.TraceIdentifier,
                Status = 0,
                Errors = _exceptionMapping.Map(e),
                Data = null
            };
            await context.Response.WriteAsJsonAsync(rs);
        }
    }
}

public static class GlobalExceptionHandlerExtensions
{
    public static IApplicationBuilder UseGlobalExceptionMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GlobalExceptionMiddleware>();
    }
}