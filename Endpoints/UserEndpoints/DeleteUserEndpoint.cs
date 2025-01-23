using WaitApi.Abstract;
using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Services.UserServices;

namespace WaitApi.Endpoints.UserEndpoints;


public class DeleteUserEndpoint(IUserService service) : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {

        app.MapDelete("/user/delete", async (DeleteUserRequest req, CancellationToken ct) =>
        {
        
            
        });

    }

}