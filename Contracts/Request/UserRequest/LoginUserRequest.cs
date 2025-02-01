namespace WaitApi.Contracts.Request.UserRequest;


public class LoginUserRequest
{

    public required string Username { get; init; }
    public required string Password { get; init; }
}