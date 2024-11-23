using System.Data;

namespace WaitApi.Database;

public interface IDbConnectionFactory{
    public Task<IDbConnection> GetDbConnection();
}
