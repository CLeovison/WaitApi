using WaitApi.Contracts.Request.UserRequest;

namespace WaitApi.Contracts.Data;


public class UserDto (CreateUserRequest userRequest)
{
    public Guid Id { get; init; }
    public required string  Fullname {get; init;} = $"{userRequest.FirstName}{userRequest.LastName}";
    public DateTime Birthday { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string Email { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime CreatAt { get; init; }
}