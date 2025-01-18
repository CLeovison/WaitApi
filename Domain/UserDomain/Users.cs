
using WaitApi.Domain.UserDomain.Common;

namespace WaitApi.Domain.UserDomain;


public class Users
{
    public required FirstName FirstName { get; init; }
    public required LastName LastName { get; init; } 
    public required Username Username { get; init; }
    public required Password Password { get; init; }
    public required Email Email { get; init; } 
    public required Birthday Birthday { get; init; }
}