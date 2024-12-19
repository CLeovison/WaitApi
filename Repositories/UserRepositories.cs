using Dapper;
using WaitApi.Contracts.Data;
using WaitApi.Database;

namespace WaitApi.Repositories;


public class UserRepositories : IUserRepositories
{
    private readonly IDbConnectionFactory _connectionString;

    public UserRepositories(IDbConnectionFactory connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<bool> CreateUserAsync(UserDto user){
        using var connection = await _connectionString.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(@"INSERT INTO waitdb(id, username,password,firstname,lastname,birthday, email) VALUES (@id,)",user);
        return result > 0;
    }

}