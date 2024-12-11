namespace WaitApi.Contracts.Request.UserRequest;

public enum Role
{
    Admin, User
}
public class CreateUserRequest
{
    public Guid Id { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public Role Role { get; init; } = Role.User;
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime RemoveUser { get; init; }
    public DateTime CreatAt { get; init; }

}