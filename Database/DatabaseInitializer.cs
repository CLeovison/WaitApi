using Dapper;

namespace WaitApi.Database;

public class DatabaseIntializer{
    private readonly IDbConnectionFactory _connectionFactory;

    public DatabaseIntializer(IDbConnectionFactory connectionFactory){
        _connectionFactory = connectionFactory;
    }

    public async Task InitializeAsync(){
        using var connection = await _connectionFactory.GetDbConnection();
        await connection.ExecuteAsync(@"CREATE TABLE IF NOT EXISTS User (
        Id CHAR(36) PRIMARY KEY, 
        Username TEXT NOT NULL,
        FullName TEXT NOT NULL,
        Email TEXT NOT NULL,
        DateOfBirth TEXT NOT NULL)");
    }

}