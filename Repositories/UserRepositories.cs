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

    public async Task<bool> CreateUserAsync(UserDto user)
    {
        using var connection = await _connectionString.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(@"INSERT INTO waitdb(id, username,password,firstname,lastname,birthday, email) VALUES (@id,)", user);
        return result > 0;
    }

    public async Task<IEnumerable<UserDto>> GetAllUserAsync()
    {
        using var connection = await _connectionString.CreateConnectionAsync();
        return await connection.QueryAsync<UserDto>(@"SELECT * From waitdb");
    }
    public async Task<UserDto?> GetUserIdAsync(Guid id)
    {
        using var connection = await _connectionString.CreateConnectionAsync();
        return await connection.QuerySingleOrDefaultAsync<UserDto>("SELECT * From Users WHERE id = @Id TOP 1", new { Id = id.ToString() });
    }




}