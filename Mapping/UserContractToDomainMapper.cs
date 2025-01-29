using System.Text.RegularExpressions;
using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Domain.UserDomain;
using WaitApi.Domain.UserDomain.Common;


namespace WaitApi.Mapping;

public static class UserContractToDomainMapper
{
    public static Users ToCreateUser(this RegisterUserRequest request)
    {
        return new Users
        {

            FirstName = new FirstName(request.FirstName, new Regex("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$")),

            LastName = new LastName(request.LastName, new Regex("^[a-zA-Z]+$")),

            Email = new Email(request.Email, new Regex("^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")),

            Birthday = new Birthday(request.Birthday,
            new Regex("^(0[1-9]|1[0-2])/(0[1-9]|1[0-9]|2[0-9]|3[0-1])/(19[0-9][0-9]|20[0-9][0-9]|2100)$")),

            Username = new Username(request.Username),

            Password = new Password(request.Password)

        };
    }
}