namespace WaitApi.Contracts.Request.UserRequest;

public class CreateUserRequest
{
    public Guid ID { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string Firstname { get; init; }
    public required string Lastname { get; init; }
    public required string Role { get; init; }
    public bool IsSoftDeleted { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; init; }
    public DateTime DeletedAt { get; init; }
}