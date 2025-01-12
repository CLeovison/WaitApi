using WaitApi.Contracts.Data;
using WaitApi.Domain.UserDomain;

namespace WaitApi.Repositories;

public interface IUserRepositories{

    Task<bool> CreateUserAsync(Users user);
    Task<IEnumerable<UserDto>> GetAllUserAsync();
    Task <UserDto?> GetUserIdAsync(Guid id);
    Task<bool> UpdateUserAsync(UserDto user);
    Task<bool> DeleteUserAsync(Guid id);
    
}