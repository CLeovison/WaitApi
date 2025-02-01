using WaitApi.Abstract;

namespace WaitApi.Contracts.Request.UserRequest;


public class UpdateUserEndpoint : IEndpoint
{
    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("/users/update", async (UpdateUserRequest req, CancellationToken ct) =>
        {
           
        });
    }
}