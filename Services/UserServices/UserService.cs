using WaitApi.Domain.UserDomain;
using WaitApi.Infrastracture;
using WaitApi.Mapping;
using WaitApi.Repositories;

namespace WaitApi.Services.UserServices;
public class UserService(IUserRepositories userRepositories, PasswordHasher passwordHasher) : IUserService
{
    public async Task<bool> RegisterUserAsync(Users user)
    {
  
        var userDto = user.ToUserDto();
        return await userRepositories.RegisterUserAsync(userDto);
    }
}