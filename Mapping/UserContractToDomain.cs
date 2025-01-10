using System.Text.RegularExpressions;

using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Domain.UserDomain;
using WaitApi.Domain.UserDomain.Common;


namespace WaitApi.Mapping;


public static class UserContractToDomain
{
    public static Users ToCreateUser(this CreateUserRequest request)
    {
        return new Users
        {

            FirstName = new FirstName(request.FirstName, new Regex("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$")),

            LastName = new LastName(request.LastName, new Regex("^[a-zA-Z]+$")),

            Email = new Email(request.Email, new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")),

            Birthday = new Birthday(DateOnly.FromDateTime(request.Birthday),
            new Regex("^(0[1-9]|1[0-2])/(0[1-9]|1\\d|2\\d|3[01])/\\d{4}$")),

            Username = new Username(request.Username),

        };
    }
}