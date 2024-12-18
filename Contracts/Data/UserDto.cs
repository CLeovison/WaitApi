namespace WaitApi.Contracts.Data;


public class UserDto
{

    public required string FullName { get; init; }
    public DateTime Birthday { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public DateTime CreatedAt { get; init; }
}