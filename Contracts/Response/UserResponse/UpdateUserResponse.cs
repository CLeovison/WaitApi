namespace WaitApi.Contracts.Response.UserResponse;

public class UpdateUserResponse
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Password { get; init; }
    public required string Email { get; init; }
}