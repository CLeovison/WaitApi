namespace WaitApi.Contracts.Request.UserRequest;

public class UpdateUserRequest
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Password { get; init; }
    public required string Email { get; init; }
}