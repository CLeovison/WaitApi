using Dapper;
using Npgsql;
using WaitApi.Models;

var builder = WebApplication.CreateBuilder(args);
var con = builder.Configuration.GetConnectionString("ConnectionStrings");
Console.WriteLine(con);

var app = builder.Build();



app.MapGet("/users", async (IConfiguration configuration) =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");

    using var connection = new NpgsqlConnection(connectionString);

    const string sql = " SELECT * FROM waitdb";

    var users = await connection.QueryAsync<Users>(sql);

    return Results.Ok(users);
});

app.MapPost("/users/register", async (IConfiguration configuration, Users user) =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    using var connection = new NpgsqlConnection(connectionString);
    const string sql =
    "INSERT INTO waitdb (username, password, firstname, lastname, birthday, email, isSoftDeleted, createdAt, id) VALUES (@username, @password, @firstname, @lastname, @birthday, @email, @issoftdeleted, @createdat, @id)";
    var addUsers = await connection.ExecuteAsync(sql, user);
    return Results.Ok(addUsers);
});

app.MapDelete("/users/{id}", async (IConfiguration configuration, int id) =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    using var connection = new NpgsqlConnection(connectionString);

    const string sql = "DELETE FROM waitdb WHERE Id=@id"; 
    var removeUser = await connection.ExecuteAsync(sql, new{id = id});

    return Results.NoContent();
});



app.Run();
