using WaitApi.Contracts.Data;

namespace WaitApi.Repositories;

public interface IUserRepositories{

    Task<bool> CreateUserAsync();
    Task<IEnumerable<UserDto>> GetUserIdAsync();
    Task<bool> DeleteUserAsync();
    
}