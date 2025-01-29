using WaitApi.Domain.UserDomain;

namespace WaitApi.Services.UserServices;


public interface IUserService{
    Task<bool> RegisterUserAsync(Users user);

}