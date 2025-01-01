using WaitApi.Contracts.Data;

namespace WaitApi.Services.UserServices;


public interface IUserService{
    Task<bool> CreateUserAsync(UserDto user);
    Task<UserDto?> GetUserAsync(Guid id);
    Task <IEnumerable<UserDto>> GetAllUserAsync();
    Task <bool> UpdateUserAsync(UserDto user);
    Task <bool> DeleteUserAsync(Guid id);
}