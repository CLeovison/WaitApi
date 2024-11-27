using System.Formats.Asn1;
using Microsoft.AspNetCore.Routing.Constraints;

namespace WaitApi.Contracts.Request.ProductRequest;

public class CreateProductRequest
{
    public required Guid ID { get; init; }

    public int Available { get; init; }
    public required string ProductName { get; init; }
    public required string ProdctType { get; init; }
    public required string Description { get; init; }
    public int Quanity { get; init; }
    public int Price { get; init; }
}