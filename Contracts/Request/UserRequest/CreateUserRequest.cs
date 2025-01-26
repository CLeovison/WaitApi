using WaitApi.Enums;

namespace WaitApi.Contracts.Request.UserRequest;


public class CreateUserRequest
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public DateOnly Birthday { get; init; }


}