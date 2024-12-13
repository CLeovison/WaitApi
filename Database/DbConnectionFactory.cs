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

    public PostgresConnectionFactory(string connectionstring)
    {
        _connectionString = connectionstring;
    }

    public async Task<IDbConnection> CreateConnectionAsync(){
        var connection = new NpgsqlConnection();
        await connection.OpenAsync();
        return connection;
    }



}