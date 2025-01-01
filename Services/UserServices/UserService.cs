using WaitApi.Contracts.Data;
using WaitApi.Repositories;
using FluentValidation;
using FluentValidation.Results;


namespace WaitApi.Services.UserServices;


public class UserService : IUserService
{

    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {

        _userRepositories = userRepositories;
    }

    public async Task<bool> CreateUserAsync(UserDto user)
    {

        var existingUser = await _userRepositories.GetUserIdAsync(user.Id);
        if (existingUser is null)
        {
            var message = $"A User with id{user.Id} already exist";

            throw new ValidationException(message, new[]{
                new ValidationFailure(nameof(UserDto),message)
            });
        }

        var 
    }
}