namespace WaitApi.Domain.Entities;


public class UserEntities
{

    public Guid ID { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public DateOnly Birthday { get; init; }
}