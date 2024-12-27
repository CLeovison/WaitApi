using Dapper;

namespace WaitApi.Database;



public class DatabaseInitializer{

    private readonly IDbConnectionFactory _connectionString;

    public DatabaseInitializer(IDbConnectionFactory connectionString)
    {
        _connectionString = connectionString;
    }
    
    public async Task InitializeAsync(){
        using var connection = await _connectionString.CreateConnectionAsync();
        await connection.ExecuteAsync(@"CREATE TABLE IF NOT EXISTS waitdb(
        id uuid NOT NULL DEFAULT gen_random_uuid() PRIMARY KEY,
        username TEXT NOT NULL,
        password TEXT NOT NULL,
        firstname TEXT NOT NULL,
        lastname TEXT NOT NULL,
        birthday DATE NOT NULL,
        email TEXT NOT NULL,
        issoftdeleted BOOLEAN NOT NULL DEFAULT false,
        createdat timestamp with time zone NOT NULL DEFAULT CURRENT_TIMESTAMP,
        role TEXT DEFAULT user
        )");
    }
}