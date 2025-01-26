using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.Entities;


public class UserEntities(Guid id, string firstname, string lastname, string username, string password, string email) : Entity(id)
{
    public required string FirstName { get; init; } = firstname;
    public required string LastName { get; init; } = lastname;
    public required string Username { get; init; } = username;
    public required string Password { get; init; } = password;
    public required string Email { get; init; } = email;
    public DateOnly Birthday { get; init; }
}