namespace WaitApi.Contracts.Data;


public class UserDto
{
    public Guid Id { get; init; }
    public required string FullName { get; init; }
    public DateTime Birthday { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime CreatAt { get; init; }
}