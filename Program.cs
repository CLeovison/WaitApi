using Dapper;
using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Database;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("ConnectionStrings:DefaultConnection")));


var app = builder.Build();


app.MapGet("/users", async (IDbConnectionFactory connectionFactory) =>
{
    using var connection = await connectionFactory.CreateConnectionAsync();
    const string sql = " SELECT * FROM waitdb";

    var users = await connection.QueryAsync<CreateUserRequest>(sql);
    return Results.Ok(users);
});

app.MapPost("/users/register", async (IDbConnectionFactory connectionFactory, CreateUserRequest user) =>{
    using var connection = await connectionFactory.CreateConnectionAsync();
    const string sql = "INSERT INTO public.waitdb(username, password, firstname, lastname, birthday, email) VALUES (@username, @password, @firstname, @lastname, @birthday, @email)";
    await connection.ExecuteAsync(sql,user);

    return Results.Ok();

});


app.Run();
