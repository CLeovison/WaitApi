using WaitApi.Contracts.Data;


namespace WaitApi.Repositories;

public interface IUserRepositories
{

    Task<bool> CreateUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> GetAllUserAsync();
    Task<UserDto?> GetUserIdAsync(Guid id);
    Task<bool> UpdateUserAsync(UserDto user);
    Task<bool> DeleteUserAsync(Guid id);

}