using WaitApi.Domain.UserDomain.ValueObjects;

namespace WaitApi.Domain.UserDomain;


public class Users
{
    public Username Username { get; init; } = default!;
    
    public Password Password { get; init; } = default!;
    public Email Email { get; init; } = default!;
    public Birthday Birthday {get; init;} = default!;
}