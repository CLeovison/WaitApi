using System.Data;
using Npgsql;                                 
 

namespace WaitApi.Database;

public interface IDbConnectionFactory{
    public Task<IDbConnection> CreateConnectionAsync();
}

public class PostgresConnectionFactory : IDbConnectionFactory{
    private readonly string _connectionString;

    public PostgresConnectionFactory(string connectionString){
        _connectionString = connectionString;
    }

    public async Task<IDbConnection> DbConnectionAsync(){
        var connection = new NpgsqlConnection(_connectionString);
        await connection.OpenAsync();
        return connection;
    }

    Task<IDbConnection> IDbConnectionFactory.CreateConnectionAsync()
    {
        throw new NotImplementedException();
    }
}