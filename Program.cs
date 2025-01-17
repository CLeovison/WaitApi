using WaitApi.Extensions;
using WaitApi.Database;

using WaitApi.Services.UserServices;
using WaitApi.Repositories;

using Dapper;
using WaitApi.Contracts.Request.UserRequest;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpoint(typeof(Program).Assembly);

builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("Database:ConnectionString")));
builder.Services.AddSingleton<IUserRepositories, UserRepositories>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddCors();


var app = builder.Build();



app.Endpoint();
app.UseCors();



app.Run();
