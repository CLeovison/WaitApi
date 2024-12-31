using WaitApi.Abstract;

using Npgsql;
using Dapper;
using WaitApi.Contracts.Data;

namespace WaitApi.Endpoints.UserEndpoints;


public class CreateUserEndpoint : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {


        app.MapPost("/users/register", async (IConfiguration configuration, UserDto user) =>
         {
      var connectionString = configuration.GetConnectionString("DefaultConnection");
      using var connection = new NpgsqlConnection(connectionString);
      const string sql =
      "INSERT INTO waitdb (username, password, firstname, lastname, birthday, email) VALUES (@username, @password, @firstname, @lastname, @birthday, @email)";
      var addUsers = await connection.ExecuteAsync(sql, user);
      return Results.Ok(addUsers);
        });
    }
}