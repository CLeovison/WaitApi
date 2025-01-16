using System.Data;
using Npgsql;

namespace WaitApi.Database;

public interface IDbConnectionFactory
{
    public Task<IDbConnection> CreateConnectionAsync();
}

public class PostgresConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public PostgresConnectionFactory(string connectionString)
    {
         _connectionString = connectionString;
    }

    public async Task<IDbConnection> CreateConnectionAsync()
    {
        var connection = new NpgsqlConnection(_connectionString);
        try
        {
            await connection.OpenAsync();
            return connection;
        }
        catch (Exception error)
        {
            {
                Console.Error.WriteLine($"Error opening PostgreSQL connection: {error.Message}"); throw;
            }
        }
    }
}