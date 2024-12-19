using WaitApi.Contracts.Data;

namespace WaitApi.Repositories;

public interface IUserRepositories{

    Task<bool> CreateUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> GetAllUserAsync();
    Task <UserDto> GetUserIdAsync();
    Task<bool> UpdateUserAsync();
    Task<bool> DeleteUserAsync();
    
}