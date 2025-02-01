using Dapper;
using WaitApi.Contracts.Data;
using WaitApi.Database;

namespace WaitApi.Repositories;


public class UserRepositories(IDbConnectionFactory connectionString) : IUserRepositories
{

    public async Task<bool> RegisterUserAsync(UserDto user)
    {
        using var connection = await connectionString.CreateConnectionAsync();
        var result = await
        connection.ExecuteAsync
        (@"INSERT INTO waitdb( username,password,firstname,lastname,birthday, email) 
        VALUES ( @username, @password, @firstname, @lastname, @birthday, @email)", user);
        return result > 0;
    }
    public async Task<UserDto?> LoginUserAsync(string username, string password)
    {
        using var connection = await connectionString.CreateConnectionAsync();


        return await connection.QuerySingleOrDefaultAsync(@"SELECT * FROM waitdb WHERE username = @username, password = @password", username);
    }
    public async Task<IEnumerable<UserDto>> ExistingUserAsync(string email, string username)
    {
        using var connection = await connectionString.CreateConnectionAsync();
        var result = await connection.QueryAsync<UserDto>
        (@"SELECT username,email FROM waitdb WHERE username = @username, email = @email",
        new { email = email.ToString(), userame = username.ToString() });
        return result;
    }
    public async Task<IEnumerable<UserDto>> GetAllUserAsync()
    {
        using var connection = await connectionString.CreateConnectionAsync();
        return await connection.QueryAsync<UserDto>(@"SELECT * From waitdb");
    }
    public async Task<UserDto?> GetUserIdAsync(Guid id)
    {
        using var connection = await connectionString.CreateConnectionAsync();
        return await connection.QuerySingleOrDefaultAsync<UserDto>(@"SELECT * From Users WHERE id = @Id TOP 1", new { Id = id.ToString() });
    }
    public async Task<IEnumerable<UserDto?>> GetUserSearchAsync()
    {
        using var connection = await connectionString.CreateConnectionAsync();
        return await connection.QueryAsync<UserDto>(@"SELECT firstname, lastname FROM waitdb WHERE firstname ILIKE %@%,lastname ILIKE %@%");
    }


    public async Task<bool> UpdateUserAsync(UserDto user)
    {
        using var connection = await connectionString.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(@"UPDATE waitdb SET FirstName = @firstname, LastName = @lastname, Birthday = @birthday, Email = @email WHERE UserId = @id");
        return result > 0;
    }
    public async Task<bool> DeleteUserAsync(Guid id)
    {
        using var connection = await connectionString.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(@"DELETE FROM waitdb where ID = @id", new { UserId = id.ToString() });
        return result > 0;
    }


}