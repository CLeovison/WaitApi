using WaitApi.Domain.UserDomain;
using WaitApi.Mapping;
using WaitApi.Repositories;

namespace WaitApi.Services.UserServices;
public class UserService(IUserRepositories userRepositories) : IUserService
{
    public async Task<bool> RegisterUserAsync(Users user)
    {

        var userDto = user.ToUserDto();
        var existingUser = await userRepositories.ExistingUserAsync(user.Username.ToString(), user.Email.ToString(), userDto);

        if (existingUser is not null)
        {
            throw new ArgumentException("The User is Already Existing");
        }


        return await userRepositories.RegisterUserAsync(userDto);
    }
}