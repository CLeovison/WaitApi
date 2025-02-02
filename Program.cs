using WaitApi.Extensions;
using WaitApi.Database;

using WaitApi.Services.UserServices;
using WaitApi.Repositories;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpoint(typeof(Program).Assembly);

builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
{
    var connectionString = config.GetValue<string>("Database:ConnectionString");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new ArgumentNullException(nameof(connectionString), "Database connection string cannot be null or empty.");
    }
    return new PostgresConnectionFactory(connectionString);
});
builder.Services.AddSingleton<IUserRepositories, UserRepositories>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddCors();


var app = builder.Build();

app.Endpoint();
app.UseCors();

app.Run();
