using API;
using API.Middleware;
using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddApi();


var app = builder.Build();

app.UseHttpLogging();
app.UseGlobalExceptionMiddleware();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", httpCtx => httpCtx.Response.WriteAsync("Hello!"));
app.Run();