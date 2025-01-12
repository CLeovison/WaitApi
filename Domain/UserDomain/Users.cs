using Microsoft.AspNetCore.Identity;
using WaitApi.Domain.UserDomain.Common;

namespace WaitApi.Domain.UserDomain;


public class Users
{
    public FirstName FirstName { get; init; } = default!;
    public LastName LastName { get; init; } = default!;
    public Username Username { get; init; } = default!;
    public Password Password { get; init; } = default!;
    public Email Email { get; init; } = default!;
    public Birthday Birthday { get; init; } = default!;
}