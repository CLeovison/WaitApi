using WaitApi.Contracts.Data;


namespace WaitApi.Repositories;

public interface IUserRepositories
{

    Task<bool> RegisterUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> ExistingUserAsync(string email, string username);
    Task<IEnumerable<UserDto>> GetAllUserAsync();
    Task<UserDto?> GetUserIdAsync(Guid id);
    Task<IEnumerable<UserDto?>> GetUserSearchAsync();
    Task<UserDto?> LoginUserAsync(string username, string password);
    Task<bool> UpdateUserAsync(UserDto user);
    Task<bool> DeleteUserAsync(Guid id);

}