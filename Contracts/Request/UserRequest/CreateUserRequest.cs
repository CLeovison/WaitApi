namespace WaitApi.Contracts.Request.UserRequest;


public class CreateUserRequest
{
    public required Guid ID { get; init; }

    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public DateTime Birthday { get; init; }
    public required string Email { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime CreatedAt { get; init; }
}
