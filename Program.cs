using WaitApi.Extensions;
using WaitApi.Database;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpoint(typeof(Program).Assembly);
builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("Database:ConnectionString")));


var app = builder.Build();

app.Endpoint();


app.Run();
