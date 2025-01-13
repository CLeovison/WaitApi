using WaitApi.Extensions;
using WaitApi.Database;

using Dapper;
using Npgsql;
using WaitApi.Mapping;

using WaitApi.Contracts.Data;



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

app.MapPost("/users/registration", async (IConfiguration configuration, UserDto users) =>
{

    var connectionString = configuration.GetConnectionString("DefaultConnection");
    using var connection = new NpgsqlConnection(connectionString);
    const string userDto = "INSERT INTO waitdb (username, password, firstname, lastname, birthday, email) VALUES (@username, @password, @firstname, @lastname, @birthday, @email)";
    var userData = users.ToCreateUser();

    var addUsers = await connection.ExecuteAsync();

    return Results.Ok(addUsers);

});

app.Run();
