using WaitApi.Contracts.Data;
using WaitApi.Repositories;

public class UserService
{

    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {

        _userRepositories = userRepositories;
    }

    public async Task<bool> CreateUserAsync(UserDto user)
    {

    
    }
}