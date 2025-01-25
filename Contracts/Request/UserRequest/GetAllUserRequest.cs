namespace WaitApi.Contracts.Request.UserRequest;

public class GetAllUserRequest
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime RemoveUser { get; init; }
    public DateTime CreatAt { get; init; }

}