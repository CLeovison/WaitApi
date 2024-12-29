using System.Reflection;
using WaitApi.Database;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("Database:ConnectionString")));


var app = builder.Build();
app.UseCors();



app.Run();
