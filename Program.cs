using WaitApi.Extensions;
using WaitApi.Database;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpoint(typeof(Program).Assembly);
builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("Database:ConnectionString")
     ?? throw new Exception("The Database Connection String was not valid")));
builder.Services.AddCors();

var app = builder.Build();

app.Endpoint();
app.UseCors();



app.Run();
