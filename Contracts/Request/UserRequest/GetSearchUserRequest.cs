namespace WaitApi.Contracts.Request.UserRequest;


public class GetSearchUserRequest
{

    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
}