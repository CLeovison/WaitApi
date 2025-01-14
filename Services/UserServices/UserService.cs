using WaitApi.Domain.UserDomain;
using WaitApi.Mapping;
using WaitApi.Repositories;

namespace WaitApi.Services.UserServices;
public class UserService : IUserService
{

    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {

        _userRepositories = userRepositories;
    }

    public async Task<bool> CreateUserAsync(Users user)
    {

        var userDto = user.ToUserDto();
        return await _userRepositories.CreateUserAsync(userDto);
    }
}