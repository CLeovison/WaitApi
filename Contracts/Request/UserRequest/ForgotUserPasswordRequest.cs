namespace WaitApi.Contracts.Request.UserRequest;

public class ForgotUserPasswordRequest
{
    public required string Email { get; init; }
}