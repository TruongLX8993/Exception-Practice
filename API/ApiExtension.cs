namespace API;

public static class ApiExtension
{
    public static void AddApi(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddControllers();
        serviceCollection.AddEndpointsApiExplorer();
        serviceCollection.AddSwaggerGen();
        serviceCollection.AddSingleton<ExceptionMapping>();
    }
}