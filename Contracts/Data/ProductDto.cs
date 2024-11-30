namespace WaitApi.Contracts.Data;


public class ProductDto
{

    public Guid ID { get; init; }
    public required string ProductName { get; init; }
    public required string ShortDescription { get; init; }
    public required string Description { get; init; }   
}