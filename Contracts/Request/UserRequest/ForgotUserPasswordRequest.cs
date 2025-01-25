namespace WaitApi.Contracts.Request.UserRequest;

public class ForgotUserPasswordRequest
{
    public Guid UserId { get; init; }
    public required string Email { get; init; }
}