namespace WaitApi.Contracts.Data;


public class OrderDto
{

    public Guid ProductId { get; init; }
    public Guid UserId { get; init; }

    public required string ProductName { get; init; }
    
}