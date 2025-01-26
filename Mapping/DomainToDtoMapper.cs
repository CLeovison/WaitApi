
using WaitApi.Contracts.Data;
using WaitApi.Domain.UserDomain;


namespace WaitApi.Mapping;

public static class DomainToDtoMapper
{
    public static UserDto ToUserDto(this Users users)
    {
        return new UserDto
        {
            FirstName = users.FirstName.Value,
            LastName = users.LastName.MaximumLength,
            Username = users.Username.MinimumLength,
            Password = users.Password.MinimumLength,
            Email = users.Email.EmailRegularX.ToString(),
       

        };
    }
}